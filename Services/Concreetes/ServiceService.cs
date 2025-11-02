using Furni.Entities;
using Furni.Services.Abstracts;
using Furni.Services.Commons;
using Furni.UnitOfWorks;

namespace Furni.Service.Concreetes
{
    public class ServiceService : Service<OurService>, IServiceService
    {
        public ServiceService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
