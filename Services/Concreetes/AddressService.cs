using Furni.Data;
using Furni.Entities;
using Furni.Repositories.Abstracts;
using Furni.Repositories.Commons;
using Furni.Services.Abstracts;
using Furni.Services.Commons;
using Furni.UnitOfWorks;

namespace Furni.Services.Concreetes
{
    public class AddressService : Service<Address>, IAddressService
    {
        public AddressService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
