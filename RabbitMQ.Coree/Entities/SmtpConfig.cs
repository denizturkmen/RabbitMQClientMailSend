﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitMQ.Coree.Entities
{
    public class SmtpConfig
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public bool UseSsl { get; set; }
    }
}
