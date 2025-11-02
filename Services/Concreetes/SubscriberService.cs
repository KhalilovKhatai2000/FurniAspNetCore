using Furni.Entities;
using Furni.Services.Abstracts;
using Furni.Services.Commons;
using Furni.UnitOfWorks;

namespace Furni.Repositories.Concreetes
{
    public class SubscriberService : Service<Subscriber>, ISubscriberService
    {
        public SubscriberService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
