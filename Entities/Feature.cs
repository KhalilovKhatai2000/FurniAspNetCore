using Furni.Entities.Commons;

namespace Furni.Entities
{
    public class Feature : EntityBase
    {
        public static Feature? _instance = null;
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Offer> Offers { get; set; } = new();
        public List<Image>? Image { get; set; }

        public static Feature Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Feature();
                }
                return _instance;
            }
        }
    }
}
