using System;
using System.Collections.Generic;
using System.Text;
using RabbitMQ.Coree.Entities;

namespace RabbitMQ.Coree.Abstract
{
    public interface ISmtpConfiguration
    {
        string Host { get; }
        int Port { get; }
        string User { get; }
        string Password { get; }
        bool UseSSL { get; }
        SmtpConfig GetSmtpConfig();
    }
}