using Furni.Entities.Commons;

namespace Furni.Entities
{
    public class Offer : EntityBase
    {
        public string Text { get; set; }
        public Guid FeatureId { get; set; }
    }
}