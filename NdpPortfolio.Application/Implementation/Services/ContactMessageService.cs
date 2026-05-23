using NdpPortfolio.Core.Interfaces.Repositories;
using NdpPortfolio.Core.Entities;
using NdpPortfolio.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace NdpPortfolio.Application.Implementations.Services
{
    public class ContactMessageService : IContactMessageService
    {
        private readonly IContactMessageRepository _contactMessageRepository;

        public ContactMessageService(IContactMessageRepository contactMessageRepository)
        {
            _contactMessageRepository = contactMessageRepository;
        }

        public bool Save(ContactMessage message)
        {
            if (!message.IsValid())
            {
                return false;
            }

            _contactMessageRepository.Add(message);
            return true;
        }

        public List<ContactMessage> GetAll()
        {
            return _contactMessageRepository.GetAll();
        }
    }
}
