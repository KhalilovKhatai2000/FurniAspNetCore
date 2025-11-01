using Furni.Entities.Commons;
using Microsoft.AspNetCore.Identity;

namespace Furni.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        public Cart? Cart { get; set; }
        public Order? Order { get; set; }
    }
}
