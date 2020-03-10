﻿using System;
using System.Collections.Generic;
using System.Text;
using RabbitMQ.Coree.Abstract;
using RabbitMQ.Coree.Entities;
using Microsoft.Extensions.Configuration;

namespace RabbitMQ.Coree.Concrete
{
    public class SmtpConfiguration : ISmtpConfiguration
    {
        private IConfiguration Configuration { get; }

        public SmtpConfiguration(IConfiguration configuration) => Configuration = configuration;

        public string Host => Configuration.GetSection("SmtpConfig:Host").Value;
        public int Port => Convert.ToInt32(Configuration.GetSection("SmtpConfig:Port").Value);
        public string User => Configuration.GetSection("SmtpConfig:User").Value;
        public string Password => Configuration.GetSection("SmtpConfig:Password").Value;
        public bool UseSSL => Convert.ToBoolean(Configuration.GetSection("SmtpConfig:UseSSL").Value);

        public SmtpConfig GetSmtpConfig()
        {
            return new SmtpConfig
            {
                Host = Host,
                Password = Password,
                Port = Port,
                User = User,
                UseSsl = UseSSL
            };
        }
    }
}
