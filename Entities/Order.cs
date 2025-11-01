using Furni.Entities.Commons;

namespace Furni.Entities
{
    public class Order : EntityBase
    {
        public decimal TotalPrice { get; set; }
        public Guid AppUserId { get; set; }
        public AppUser? AppUser { get; set; }
        public ICollection<OrderItem> Items { get; set; } = new List<OrderItem>();
    }
}
