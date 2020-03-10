using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitMQ.Coree.Data
{
    public interface IDataModel<T>
    {
        IEnumerable<T> GetData();
    }
}

