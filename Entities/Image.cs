using Furni.Entities.Commons;
using Furni.Enums;

namespace Furni.Entities
{
    public class Image : EntityBase
    {
        public string Alt { get; set; }
        public string Url { get; set; }
        public ImageType ImageType { get; set; }
        public Guid? RelatedEntityId { get; set; }
        public string? RelatedEntityType { get; set; }
    }
}
