using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace RabbitMQ.Coree.Abstract
{
    public interface IConsumerService : IDisposable
    {
        Task Start();
        void Stop();
    }
}
