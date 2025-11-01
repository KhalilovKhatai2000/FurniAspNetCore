using Furni.Data;
using Furni.Entities;
using Furni.Repositories.Abstracts;
using Furni.Repositories.Commons;

namespace Furni.Repositories.Concreetes
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(FurniDbContext dbContext) : base(dbContext)
        {
        }
    }
}
