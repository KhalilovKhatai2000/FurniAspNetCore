using Furni.Entities.Commons;
using Furni.UnitOfWorks;
using System;
using System.Linq.Expressions;

namespace Furni.Services.Commons
{
    public class Service<TEntity> : IService<TEntity> where TEntity : EntityBase, new()
    {
        private readonly IUnitOfWork _unitOfWork;

        public Service(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public virtual bool Any(Expression<Func<TEntity, bool>>? predicate = null)
        {
            return _unitOfWork.GetRepository<TEntity>().Any(predicate);
        }

        public async virtual Task<bool> AnyAsync(Expression<Func<TEntity, bool>>? predicate = null)
        {
            return await _unitOfWork.GetRepository<TEntity>().AnyAsync(predicate);
        }

        public virtual TEntity Create(TEntity entity)
        {
            return _unitOfWork.GetRepository<TEntity>().Create(entity);
        }

        public async virtual Task<TEntity> CreateAsync(TEntity entity)
        {
            return await _unitOfWork.GetRepository<TEntity>().CreateAsync(entity);
        }

        public virtual void Delete(Guid id)
        {
            _unitOfWork.GetRepository<TEntity>().Delete(id);
        }

        public virtual async Task DeleteAsync(Guid id)
        {
            await _unitOfWork.GetRepository<TEntity>().DeleteAsync(id);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return _unitOfWork.GetRepository<TEntity>().GetAll();
        }

        public virtual IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>>? predicate = null, params Expression<Func<TEntity, object>>?[] includes)
        {
            return _unitOfWork.GetRepository<TEntity>().GetAll(predicate, includes);
        }

        public virtual Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return _unitOfWork.GetRepository<TEntity>().GetAllAsync();
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>>? predicate = null, params Expression<Func<TEntity, object>>?[] includes)
        {
            return await _unitOfWork.GetRepository<TEntity>().GetAllAsync(predicate, includes);
        }

        public virtual TEntity GetById(Guid id)
        {
            return _unitOfWork.GetRepository<TEntity>().GetById(id);
        }

        public virtual TEntity GetById(Guid id, Expression<Func<TEntity, bool>>? predicate = null, params Expression<Func<TEntity, object>>?[] includes)
        {
            return _unitOfWork.GetRepository<TEntity>().GetById(id, predicate, includes);
        }

        public async virtual Task<TEntity> GetByIdAsync(Guid id)
        {
            return await _unitOfWork.GetRepository<TEntity>().GetByIdAsync(id);
        }

        public virtual Task<TEntity> GetByIdAsync(Guid id, Expression<Func<TEntity, bool>>? predicate = null, params Expression<Func<TEntity, object>>?[] includes)
        {
            return _unitOfWork.GetRepository<TEntity>().GetByIdAsync(id, predicate, includes);
        }

        public virtual TEntity Update(TEntity entity)
        {
            return _unitOfWork.GetRepository<TEntity>().Update(entity);
        }

        public async virtual Task<TEntity> UpdateAsync(TEntity entity)
        {
            return await _unitOfWork.GetRepository<TEntity>().UpdateAsync(entity);
        }
    }
}
