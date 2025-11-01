using Furni.Data;
using Furni.Entities;
using Furni.Repositories.Abstracts;
using Furni.Repositories.Commons;

namespace Furni.Repositories.Concreetes
{
    public class CartRepository : Repository<Cart>, ICartItemRepository
    {
        public CartRepository(FurniDbContext dbContext) : base(dbContext)
        {
        }
    }
}
