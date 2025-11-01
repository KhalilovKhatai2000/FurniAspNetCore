using Furni.Entities.Commons;
using System.Linq.Expressions;

namespace Furni.Repositories.Commons
{
    public interface IRepository<TEntity> where TEntity : EntityBase, new()
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<IEnumerable<TEntity>> GetAllAsync(
            Expression<Func<TEntity, bool>>? predicate = null,
            params Expression<Func<TEntity, object>>?[] includes
        );
        Task<TEntity> CreateAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task<TEntity> DeleteAsync(Guid id);
        Task<TEntity> GetByIdAsync(Guid id);
        Task<TEntity> GetByIdAsync(
            Guid id,
            Expression<Func<TEntity, bool>>? predicate = null,
            params Expression<Func<TEntity, object>>?[] includes
        );
        Task<bool> AnyAsync(Expression<Func<TEntity, bool>>? predicate = null);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetAll(
            Expression<Func<TEntity, bool>>? predicate = null,
            params Expression<Func<TEntity, object>>?[] includes
        );
        TEntity Create(TEntity entity);
        TEntity Update(TEntity entity);
        TEntity Delete(Guid id);
        TEntity GetById(Guid id);
        TEntity GetById(
            Guid id,
            Expression<Func<TEntity, bool>>? predicate = null,
            params Expression<Func<TEntity, object>>?[] includes
        );
        bool Any(Expression<Func<TEntity, bool>>? predicate = null);
    }
}
