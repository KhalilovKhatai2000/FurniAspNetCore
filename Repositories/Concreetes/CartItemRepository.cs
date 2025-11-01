using Furni.Data;
using Furni.Entities;
using Furni.Repositories.Abstracts;
using Furni.Repositories.Commons;

namespace Furni.Repositories.Concreetes
{
    public class CartItemRepository : Repository<CartItem>, ICartItemRepository
    {
        public CartItemRepository(FurniDbContext dbContext) : base(dbContext)
        {
        }
    }
}
