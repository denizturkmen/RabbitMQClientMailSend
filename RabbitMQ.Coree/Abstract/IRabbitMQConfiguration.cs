using System;
using System.Collections.Generic;
using System.Text;
using RabbitMQ.Client;

namespace RabbitMQ.Coree.Abstract
{
    public interface IRabbitMQConfiguration
    {
        public string HostName { get; }
        public string UserName { get; }
        public string Password { get; }



    }
}
