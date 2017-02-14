using BusinessLogic.Entities;
using BusinessLogic.Infrastructure;

namespace BusinessLogic.Services
{
    public interface IMessageService : IEntityServiceBase<Message>
    {
    }

    [EventLog]
    internal class MessageService : EntityServiceBase<Message>, IMessageService
    {
        public MessageService(IRepository<Message> repository)
            : base(repository)
        {
        }
    }
}
