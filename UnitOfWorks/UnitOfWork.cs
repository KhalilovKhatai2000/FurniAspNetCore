using Furni.Data;
using Furni.Entities.Commons;
using Furni.Repositories.Commons;
using System.Collections.Concurrent;

namespace Furni.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly FurniDbContext _context;
        private readonly ConcurrentDictionary<Type, object> _repositories;

        public UnitOfWork(FurniDbContext context)
        {
            _context = context;
            _repositories = new ConcurrentDictionary<Type, object>();
        }

        public IRepository<T> GetRepository<T>() where T : EntityBase, new()
        {
            if (_repositories.TryGetValue(typeof(T), out var repository))
                return (IRepository<T>)repository;

            var newRepository = new Repository<T>(_context);
            _repositories.TryAdd(typeof(T), newRepository);

            return newRepository;
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

    }
}
