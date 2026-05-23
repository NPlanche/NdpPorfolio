using NdpPortfolio.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NdpPortfolio.Core.Interfaces.Services
{
    public interface IContactMessageService
    {
        bool Save(ContactMessage message);
        List<ContactMessage> GetAll();
    }
}
