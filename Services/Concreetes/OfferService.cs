using Furni.Entities;
using Furni.Services.Abstracts;
using Furni.Services.Commons;
using Furni.UnitOfWorks;

namespace Furni.Services.Concreetes
{
    public class OfferService : Service<Offer>, IOfferService
    {
        public OfferService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
