using Furni.Entities;
using Furni.Services.Abstracts;
using Furni.Services.Commons;
using Furni.UnitOfWorks;

namespace Furni.Services.Concreetes
{
    public class FeatureService : Service<Feature>, IFeatureService
    {
        public FeatureService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
