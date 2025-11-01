using Furni.Entities.Commons;

namespace Furni.Entities
{
    public class Message : EntityBase
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Body { get; set; }
    }
}
