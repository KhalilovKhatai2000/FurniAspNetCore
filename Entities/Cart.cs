using Furni.Entities.Commons;

namespace Furni.Entities
{
    public class Cart : EntityBase
    {
        public decimal TotalPrice { get; set; }
        public Guid AppUserId { get; set; }
        public AppUser? AppUser { get; set; }
        public ICollection<CartItem> Items { get; set; } = new List<CartItem>();
    }
}
