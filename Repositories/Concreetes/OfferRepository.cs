using Furni.Data;
using Furni.Entities;
using Furni.Repositories.Abstracts;
using Furni.Repositories.Commons;

namespace Furni.Repositories.Concreetes
{
    public class OfferRepository : Repository<Offer>, IOfferRepository
    {
        public OfferRepository(FurniDbContext dbContext) : base(dbContext)
        {
        }
    }
}
