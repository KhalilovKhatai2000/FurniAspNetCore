using Furni.Entities;
using Furni.Services.Abstracts;
using Furni.Services.Commons;
using Furni.UnitOfWorks;

namespace Furni.Service.Concreetes
{
    public class OrderItemService : Service<OrderItem>, IOrderItemService
    {
        public OrderItemService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
