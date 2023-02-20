using _1.Domain;

namespace _2.Core;

public interface IProvinceRepository : IBaseRepository<Province>
{
    public Task<Province> GetByIdWithPointOfInterestAsync(Guid id);
}