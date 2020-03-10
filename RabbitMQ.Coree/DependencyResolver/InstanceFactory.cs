using System;
using System.Collections.Generic;
using System.Text;
using Ninject;

namespace RabbitMQ.Coree.DependencyResolver
{
    public class InstanceFactory
    {
        public static T GetInstance<T>()
        {
            var kernel = new StandardKernel(new BusinessModule());
            return kernel.Get<T>();
        }
    }
}

