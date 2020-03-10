using System;
using System.Collections.Generic;
using System.Text;
using RabbitMQ.Client;

namespace RabbitMQ.Coree.Abstract
{
    public interface IRabbitMQService
    {
        IConnection GetConnection();
        IModel GetModel(IConnection connection);
    }
}
