using Furni.Data;
using Furni.Entities;
using Furni.Repositories.Abstracts;
using Furni.Repositories.Commons;

namespace Furni.Repositories.Concreetes
{
    public class ContactRepository : Repository<Contact>, IContactRepository
    {
        public ContactRepository(FurniDbContext dbContext) : base(dbContext)
        {
        }
    }
}
