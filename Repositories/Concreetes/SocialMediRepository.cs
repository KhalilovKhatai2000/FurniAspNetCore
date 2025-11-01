using Furni.Data;
using Furni.Entities;
using Furni.Repositories.Abstracts;
using Furni.Repositories.Commons;

namespace Furni.Repositories.Concreetes
{
    public class SocialMediRepository : Repository<SocialMedia>, ISocialMediaRepository
    {
        public SocialMediRepository(FurniDbContext dbContext) : base(dbContext)
        {
        }
    }
}
