using NdpPortfolio.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NdpPortfolio.Core.Interfaces.Repositories
{
    public interface IContactMessageRepository
    {
        void Add(ContactMessage message);
        List<ContactMessage> GetAll();
   
    }
}
