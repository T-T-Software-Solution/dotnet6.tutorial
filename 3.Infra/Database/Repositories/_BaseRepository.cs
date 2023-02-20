using _1.Domain;
using _2.Core;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace _3.Infra;

public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
{
    protected readonly DataContext _context;
    public BaseRepository(DataContext context)
    {
        this._context = context;
    }

    public async Task<TEntity> GetByIdAsync(Guid id)
    {
        return await _context.Set<TEntity>().FindAsync(id);
    }

    public async Task<bool> DoesExist(Expression<Func<TEntity, bool>> predicate)
    {
        return await _context.Set<TEntity>().AnyAsync(predicate);
    }

    public async Task<TEntity> AddAsync(TEntity entity)
    {
        entity.Id = Guid.NewGuid();
        entity.CreatedUTC = DateTime.UtcNow;
        entity.UpdatedUTC = entity.CreatedUTC;
        entity.IsActive = true;

        await _context.Set<TEntity>().AddAsync(entity);

        return entity;
    }

    public TEntity Update(TEntity entity)
    {
        entity.UpdatedUTC = DateTime.UtcNow;

        return entity;
    }

    public TEntity Remove(TEntity entity)
    {
        entity.UpdatedUTC = DateTime.UtcNow;
        entity.IsActive = false;

        return entity;
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
}