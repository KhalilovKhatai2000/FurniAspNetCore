using Furni.Entities.Commons;
using Furni.Enums;

namespace Furni.Entities
{
    public class Slider : EntityBase
    {
        public string Tittle { get; set; }
        public string Description { get; set; }
        public PageKey Page {  get; set; }
        public Guid SliderImageId { get; set; }
        public SliderImage? SliderImage { get; set; }
    }
}
