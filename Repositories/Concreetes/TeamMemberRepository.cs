using Furni.Data;
using Furni.Entities;
using Furni.Repositories.Abstracts;
using Furni.Repositories.Commons;

namespace Furni.Repositories.Concreetes
{
    public class TeamMemberRepository : Repository<TeamMember>, ITeamMemberRepository
    {
        public TeamMemberRepository(FurniDbContext dbContext) : base(dbContext)
        {
        }
    }
}
