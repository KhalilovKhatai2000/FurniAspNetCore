using Furni.Data;
using Furni.Entities;
using Furni.Repositories.Abstracts;
using Furni.Repositories.Commons;

namespace Furni.Repositories.Concreetes
{
    public class AddressRepository : Repository<Address>, IAddressRepository
    {
        public AddressRepository(FurniDbContext dbContext) : base(dbContext)
        {
        }
    }
}
