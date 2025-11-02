using Furni.Entities;
using Furni.Repositories.Abstracts;
using Furni.Services.Commons;
using Furni.UnitOfWorks;

namespace Furni.Services.Concreetes
{
    public class AboutService : Service<About>, IAboutService
    {
        public AboutService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
