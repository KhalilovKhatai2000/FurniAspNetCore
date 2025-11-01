using Furni.Data;
using Furni.Entities.Commons;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Furni.Repositories.Commons
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : EntityBase, new()
    {
        protected readonly FurniDbContext _dbContext;
        public DbSet<TEntity> _dbSet;

        public Repository(FurniDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntity>();
        }

        public bool Any(Expression<Func<TEntity, bool>>? predicate = null)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AnyAsync(Expression<Func<TEntity, bool>>? predicate = null)
        {
            throw new NotImplementedException();
        }

        public TEntity Create(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> CreateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>>? predicate = null, params Expression<Func<TEntity, object>>?[] includes)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>>? predicate = null, params Expression<Func<TEntity, object>>?[] includes)
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(Guid id, Expression<Func<TEntity, bool>>? predicate = null, params Expression<Func<TEntity, object>>?[] includes)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetByIdAsync(Guid id, Expression<Func<TEntity, bool>>? predicate = null, params Expression<Func<TEntity, object>>?[] includes)
        {
            throw new NotImplementedException();
        }

        public TEntity Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
