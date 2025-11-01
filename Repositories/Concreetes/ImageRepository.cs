using Furni.Data;
using Furni.Entities;
using Furni.Repositories.Abstracts;
using Furni.Repositories.Commons;

namespace Furni.Repositories.Concreetes
{
    public class ImageRepository : Repository<Image>, IImageRepository
    {
        public ImageRepository(FurniDbContext dbContext) : base(dbContext)
        {
        }
    }
}
