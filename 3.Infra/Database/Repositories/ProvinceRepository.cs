using _1.Domain;
using _2.Core;
using Microsoft.EntityFrameworkCore;

namespace _3.Infra;
public class ProvinceRepository: BaseRepository<Province>, IProvinceRepository
{
    public ProvinceRepository(DataContext context) : base(context)
    {
    }

    public async Task<Province> GetByIdWithPointOfInterestAsync(Guid id)
    {
        return await base._context.Provinces
                    .Include(c=>c.PointOfInterests)
                    .FirstOrDefaultAsync(c=>c.Id == id);
    }
}