using Furni.Entities;
using Furni.Repositories.Abstracts;
using Furni.Services.Abstracts;
using Furni.Services.Commons;
using Furni.UnitOfWorks;

namespace Furni.Services.Concreetes
{
    public class ContactService : Service<Contact>, IContactService
    {
        public ContactService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
