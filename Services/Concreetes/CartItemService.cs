using Furni.Entities;
using Furni.Services.Abstracts;
using Furni.Services.Commons;
using Furni.UnitOfWorks;

namespace Furni.Services.Concreetes
{
    public class CartItemService : Service<CartItem>, ICartItemService
    {
        public CartItemService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
