using Furni.Data;
using Furni.Entities;
using Furni.Repositories.Abstracts;
using Furni.Repositories.Commons;

namespace Furni.Repositories.Concreetes
{
    public class MessageRepository : Repository<Message>, IMessageRepository
    {
        public MessageRepository(FurniDbContext dbContext) : base(dbContext)
        {
        }
    }
}
