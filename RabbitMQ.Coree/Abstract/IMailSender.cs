using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Coree.Entities;

namespace RabbitMQ.Coree.Abstract
{
    public interface IMailSender
    {
        Task<MailSendResult> SendMailAsync(MailMessageData emailMessage);
    }
}
