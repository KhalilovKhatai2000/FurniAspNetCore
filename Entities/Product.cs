using Furni.Entities.Commons;

namespace Furni.Entities
{
    public class Product : EntityBase
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public Guid? ImageId { get; set; }
        public Image? Image { get; set; }
    }
}
