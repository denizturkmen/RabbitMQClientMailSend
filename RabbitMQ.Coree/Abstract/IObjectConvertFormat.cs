using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitMQ.Coree.Abstract
{
    public interface IObjectConvertFormat
    {
        public TEntity JsonToObject<TEntity>(string jsonString) where TEntity : class, new();
        public string ObjectToJson<TEntity>(TEntity entityObject) where TEntity : class, new();
        public TEntity ParseObjectDataArray<TEntity>(byte[] rawBytes) where TEntity : class, new();
    }
}
