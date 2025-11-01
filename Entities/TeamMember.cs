using Furni.Entities.Commons;

namespace Furni.Entities
{
    public class TeamMember : EntityBase
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FullName { get
            {
                return Name + " " + Surname;
            } }
        public string Title { get; set; }
        public string Description { get; set; }
        public Guid? ImageId { get; set; }
        public Image? ProfilePhoto { get; set; }
    }
}
