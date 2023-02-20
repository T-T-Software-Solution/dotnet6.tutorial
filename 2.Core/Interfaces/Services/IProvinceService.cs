using _1.Domain;

namespace _2.Core;

public interface IProvinceService
{
    Task<ProvinceServiceResponse> CreateNewProvinceAsync(ProvinceServiceInput input);
    Task<ProvinceServiceResponse> UpdateProvinceAsync(Guid provinceId, ProvinceServiceInput input);
    Task<ProvinceServiceResponse> DeleteProvinceAsync(Guid provinceId);
    Task<ProvinceServiceResponse> GetProvinceAsync(Guid provinceId);
    Task<ProvinceServiceResponseWithPointOfInterest> GetProvinceAsyncWithPointOfInterestAsync(Guid provinceId);
    Task<ProvinceServiceResponseWithPaging> GetListOfAllActiveProvincesAsync(int pageNumber, int pageSize);
    Task<ProvinceServiceResponseWithPaging> GetListOfActiveProvincesByNameAsync(string name, int pageNumber, int pageSize);
    Task<ProvinceServiceResponseWithPaging> GetListOfAllActiveProvincesWithPointOfInterestAsync(int pageNumber, int pageSize);
    
}

public class ProvinceServiceInput
{
    public string Name { get; set; }
    public string Description { get; set; }
}

public class ProvinceServiceResponse: BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
}

public class ProvinceServiceResponsePointOfInterest
{
    public Guid Id { get; set; }
    public string Name { get; set; }
}

public class ProvinceServiceResponseWithPointOfInterest
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public List<ProvinceServiceResponsePointOfInterest> PointOfInterests { get; set; }
}

public class ProvinceServiceResponseWithPaging
{
    public int TotalRows { get; set; }
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
    public List<ProvinceServiceResponse> Provinces { get; set; }
}