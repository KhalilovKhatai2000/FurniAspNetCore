using Furni.Data;
using Furni.Entities;
using Furni.Repositories.Abstracts;
using Furni.Repositories.Commons;

namespace Furni.Repositories.Concreetes
{
    public class ServiceRepository : Repository<Service>, IServiceRepository
    {
        public ServiceRepository(FurniDbContext dbContext) : base(dbContext)
        {
        }
    }
}
