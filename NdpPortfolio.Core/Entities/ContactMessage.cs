using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace NdpPortfolio.Core.Entities
{
    public class ContactMessage
    {
        public int Id { get; set; }
        public string FromEmail { get; set; } = string.Empty;
        public string Subject { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public DateTime ReceivedAt { get; set; } = DateTime.UtcNow;

        public bool IsValid()
        {
            return IsValidEmail(FromEmail)
                && !string.IsNullOrWhiteSpace(Subject)
                && !string.IsNullOrWhiteSpace(Message)
                && Message.Trim().Length >= 10;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var _ = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
