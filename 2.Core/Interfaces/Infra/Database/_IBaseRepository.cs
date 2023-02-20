using System.Linq.Expressions;
using _1.Domain;

namespace _2.Core;

public interface IBaseRepository<TEntity> where TEntity:IBaseEntity
{
    Task<TEntity> GetByIdAsync(Guid id);
    Task<bool> DoesExist(Expression<Func<TEntity, bool>> predicate);
    Task<TEntity> AddAsync(TEntity entity);
    TEntity Update(TEntity entity);
    TEntity Remove(TEntity entity);
    Task SaveChangesAsync();
}