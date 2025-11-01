using Furni.Entities.Commons;

namespace Furni.Entities
{
    public sealed class SliderImage : EntityBase
    {
        private static SliderImage? _instance = null;
        public string Alt { get; set; }
        public string Url { get; set; }
        public List<Slider>? Slider { get; set; }

        private SliderImage()
        {

        }

        public static SliderImage Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SliderImage();
                }
                return _instance;
            }
        }

    }
}
