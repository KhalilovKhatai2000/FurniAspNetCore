using Furni.Entities;
using Furni.Services.Abstracts;
using Furni.Services.Commons;
using Furni.UnitOfWorks;

namespace Furni.Services.Concreetes
{
    public class CartService : Service<Cart>, ICartItemService
    {
        public CartService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
