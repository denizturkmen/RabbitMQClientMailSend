using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitMQ.Coree.Abstract
{
    public interface IPublisherService
    {
        //List şeklinde mail göndermek için IEnurable
        public void Enqueue<TEntity>(IEnumerable<TEntity> queueDataModels, string queueName)
            where TEntity : class, new();
    }
}
