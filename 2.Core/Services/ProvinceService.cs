using _1.Domain;

namespace _2.Core;

public class ProvinceService : IProvinceService
{
    private readonly IProvinceRepository _repository;

    public ProvinceService(IProvinceRepository repository)
    {
        _repository = repository;
    }

    private ProvinceServiceResponse ConvertToResponseModel(Province entity)
    {
        return new ProvinceServiceResponse()
        {
            Id = entity.Id,
            Name = entity.Name,
            Description = entity.Description,
            CreatedUTC = entity.CreatedUTC,
            UpdatedUTC = entity.UpdatedUTC,
            IsActive = entity.IsActive
        };
    }

    public async Task<ProvinceServiceResponse> CreateNewProvinceAsync(ProvinceServiceInput input)
    {
        // Return duplication error if the name is used already.
        bool isTheNameAlreadyUsed = await (_repository.DoesExist(c=>c.Name == input.Name));
        if(isTheNameAlreadyUsed)
            throw new ArgumentException("Province name is used already. Please choose another name");

        Province entity = new Province(){
            Name = input.Name,
            Description = input.Description
        };

        Province insertedEntity = await _repository.AddAsync(entity);
        await _repository.SaveChangesAsync();

        return ConvertToResponseModel(insertedEntity);
    }

    public async Task<ProvinceServiceResponse> UpdateProvinceAsync(Guid provinceId, ProvinceServiceInput input)
    {
        Province existingProvince = await _repository.GetByIdAsync(provinceId);
        
        bool isTheEntityNotExist = (existingProvince == null);
        if(isTheEntityNotExist)
            throw new ArgumentException("Cannot update the province. It does not exist.");

        existingProvince.Name = input.Name;
        existingProvince.Description = input.Description;
        existingProvince = _repository.Update(existingProvince);
        await _repository.SaveChangesAsync();

        return ConvertToResponseModel(existingProvince);
    }

    public async Task<ProvinceServiceResponse> DeleteProvinceAsync(Guid provinceId)
    {
        Province existingProvince = await _repository.GetByIdAsync(provinceId);
        
        bool isTheEntityNotExist = (existingProvince == null);
        if(isTheEntityNotExist)
            throw new ArgumentException("Cannot delete the province. It does not exist.");

        existingProvince = _repository.Remove(existingProvince);
        await _repository.SaveChangesAsync();

        return ConvertToResponseModel(existingProvince);
    }

    public async Task<ProvinceServiceResponse> GetProvinceAsync(Guid provinceId)
    {
        Province existingProvince = await _repository.GetByIdAsync(provinceId);

        bool isTheEntityNotExist = (existingProvince == null);
        if(isTheEntityNotExist)
            throw new ArgumentException("Cannot get the province. It does not exist.");

        return ConvertToResponseModel(existingProvince);
    }

    public async Task<ProvinceServiceResponseWithPointOfInterest> GetProvinceAsyncWithPointOfInterestAsync(Guid provinceId)
    {
        Province existingProvince = await _repository.GetByIdWithPointOfInterestAsync(provinceId);

        bool isTheEntityNotExist = (existingProvince == null);
        if(isTheEntityNotExist)
            throw new ArgumentException("Cannot get the province. It does not exist.");

        ProvinceServiceResponseWithPointOfInterest response = new ProvinceServiceResponseWithPointOfInterest()
        {
            Id = existingProvince.Id,
            Name = existingProvince.Name,
            PointOfInterests = new List<ProvinceServiceResponsePointOfInterest>()
        };

        foreach(PointOfInterest pointOfInterestEntity in existingProvince.PointOfInterests
                    .Where(c=>c.IsActive).OrderBy(c=>c.Name).ToList())
        {
            ProvinceServiceResponsePointOfInterest pointOfInterestResponse = new ProvinceServiceResponsePointOfInterest()
            {
                Id = pointOfInterestEntity.Id,
                Name = pointOfInterestEntity.Name
            };

            response.PointOfInterests.Add(pointOfInterestResponse);
        }

        return response;
    }

    public Task<ProvinceServiceResponseWithPaging> GetListOfAllActiveProvincesAsync(int pageNumber, int pageSize)
    {
        throw new NotImplementedException();
    }

    public Task<ProvinceServiceResponseWithPaging> GetListOfActiveProvincesByNameAsync(string name, int pageNumber, int pageSize)
    {
        throw new NotImplementedException();
    }

    public Task<ProvinceServiceResponseWithPaging> GetListOfAllActiveProvincesWithPointOfInterestAsync(int pageNumber, int pageSize)
    {
        throw new NotImplementedException();
    }

}