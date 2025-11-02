using Furni.Entities;
using Furni.Services.Abstracts;
using Furni.Services.Commons;
using Furni.UnitOfWorks;

namespace Furni.Service.Concreetes
{
    public class OrderService : Service<Order>, IOrderService
    {
        public OrderService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
