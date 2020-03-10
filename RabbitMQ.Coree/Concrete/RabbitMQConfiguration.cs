using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using RabbitMQ.Coree.Abstract;

namespace RabbitMQ.Coree.Concrete
{
    public class RabbitMQConfiguration : IRabbitMQConfiguration
    {
        private IConfiguration _configuration;

        public RabbitMQConfiguration(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string HostName => _configuration.GetSection("RabbitMQConfiguration:HostName").Value;
        public string UserName => _configuration.GetSection("RabbitMQConfiguration:UserName").Value;
        public string Password => _configuration.GetSection("RabbitMQConfiguration:Password").Value;
    }
}
