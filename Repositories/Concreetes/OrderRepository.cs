using Furni.Data;
using Furni.Entities;
using Furni.Repositories.Abstracts;
using Furni.Repositories.Commons;

namespace Furni.Repositories.Concreetes
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(FurniDbContext dbContext) : base(dbContext)
        {
        }
    }
}
