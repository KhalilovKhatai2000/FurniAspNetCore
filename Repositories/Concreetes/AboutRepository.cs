using Furni.Data;
using Furni.Entities;
using Furni.Repositories.Abstracts;
using Furni.Repositories.Commons;

namespace Furni.Repositories.Concreetes
{
    public class AboutRepository : Repository<About>, IAboutRepository
    {
        public AboutRepository(FurniDbContext dbContext) : base(dbContext)
        {
        }
    }
}
