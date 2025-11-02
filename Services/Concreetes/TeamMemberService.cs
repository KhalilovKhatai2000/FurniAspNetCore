using Furni.Entities;
using Furni.Services.Abstracts;
using Furni.Services.Commons;
using Furni.UnitOfWorks;

namespace Furni.Repositories.Concreetes
{
    public class TeamMemberService : Service<TeamMember>, ITeamMemberService
    {
        public TeamMemberService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
