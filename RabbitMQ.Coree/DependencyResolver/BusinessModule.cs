using System;
using System.Collections.Generic;
using System.Text;

using Ninject.Modules;
using RabbitMQ.Coree.Abstract;
using RabbitMQ.Coree.Concrete;

namespace RabbitMQ.Coree.DependencyResolver
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IRabbitMQService>().To<RabbitMQService>().InSingletonScope();
            Bind<IRabbitMQConfiguration>().To<RabbitMQConfiguration>().InSingletonScope();
            Bind<IObjectConvertFormat>().To<ObjectConvertFormat>().InSingletonScope();
        }
    }
}

