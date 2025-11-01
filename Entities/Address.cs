using Furni.Entities.Commons;

namespace Furni.Entities
{
    public class Address : EntityBase
    {
        public string City { get; set; }
        public string Region { get; set; }
        public string Street { get; set; }
        public int PostalCode { get; set; }
    }
}
