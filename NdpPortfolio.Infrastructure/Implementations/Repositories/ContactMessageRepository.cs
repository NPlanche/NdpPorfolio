using NdpPortfolio.Core.Interfaces.Repositories;
using NdpPortfolio.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NdpPortfolio.Infrastructure.Implementations.Repositories
{
    public class ContactMessageRepository : IContactMessageRepository
    {
        private readonly List<ContactMessage> _messages = new();
        public void Add(ContactMessage message)
        {
            message.Id = _messages.Count + 1;
            _messages.Add(message);
        }

        public List<ContactMessage> GetAll()
        {
            return _messages;
        }
    }
}
