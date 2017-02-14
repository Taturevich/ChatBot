using System;
using System.Xml.Linq;
using BusinessLogic.BotConfiguration;
using BusinessLogic.Entities;
using BusinessLogic.Enums;
using BusinessLogic.Infrastructure;
using BusinessLogic.Models;

namespace BusinessLogic.Services
{
    public interface IBotService : IEntityServiceBase<Bot>
    {
        Message GetAnswer(string input);
    }

    [EventLog]
    internal class BotService : EntityServiceBase<Bot>, IBotService
    {
        private readonly BotInitialization _botInit;
        private readonly IRepository<Message> _messageRepository;

        public BotService(
            IRepository<Bot> repository,
            IRepository<Message> messageRepository)
            : base(repository)
        {
            _botInit = new BotInitialization();
            _messageRepository = messageRepository;
        }

        public Message GetAnswer(string input)
        {
            var answer = new Message();
            answer.Id = Guid.NewGuid();
            answer.Date = DateTime.Now;
            answer.Text = _botInit.GetOutput(input);
            answer.SenderType = SenderType.Bot;
            _messageRepository.Add(answer);

            return answer;
        }
    }
}
