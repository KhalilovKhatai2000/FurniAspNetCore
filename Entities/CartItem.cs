using Furni.Entities.Commons;

namespace Furni.Entities
{
    public class CartItem : EntityBase
    {
        public Guid CartId { get; set; }
        public Cart? Cart { get; set; }
        public Guid ProductId { get; set; }
        public Product? Product { get; set; }
        public int Count { get; set; }
        public decimal ItemPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
