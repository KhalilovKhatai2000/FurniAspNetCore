using Furni.Entities;
using Furni.Services.Abstracts;
using Furni.Services.Commons;
using Furni.UnitOfWorks;

namespace Furni.Service.Concreetes
{
    public class SocialMediService : Service<SocialMedia>, ISocialMediaService
    {
        public SocialMediService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
