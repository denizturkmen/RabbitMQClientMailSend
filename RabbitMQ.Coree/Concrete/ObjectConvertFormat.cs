using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using RabbitMQ.Coree.Abstract;

namespace RabbitMQ.Coree.Concrete
{
    public class ObjectConvertFormat : IObjectConvertFormat
    {

        public TEntity JsonToObject<TEntity>(string jsonString) where TEntity : class, new()
        {
            var objectData = JsonConvert.DeserializeObject<TEntity>(jsonString);
            return objectData;
        }

        public string ObjectToJson<TEntity>(TEntity entityObject) where TEntity : class, new()
        {
            var jsonString = JsonConvert.SerializeObject(entityObject);
            return jsonString;
        }

        public TEntity ParseObjectDataArray<TEntity>(byte[] rawBytes) where TEntity : class, new()
        {
            var stringData = Encoding.UTF8.GetString(rawBytes);
            return JsonToObject<TEntity>(stringData);
        }
    }

}

