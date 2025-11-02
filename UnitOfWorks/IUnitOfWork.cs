using Furni.Entities.Commons;
using Furni.Repositories.Commons;

namespace Furni.UnitOfWorks
{
    public interface IUnitOfWork
    {
        int SaveChanges();
        Task<int> SaveChangesAsync();
        IRepository<T> GetRepository<T>() where T : EntityBase, new();
    }
}
