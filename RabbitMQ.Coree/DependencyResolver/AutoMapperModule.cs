using System;
using System.Collections.Generic;
using System.Text;
using Ninject.Modules;
using AutoMapper;

namespace RabbitMQ.Coree.DependencyResolver
{
    public class AutoMapperModule : NinjectModule
    {
        [Obsolete]
#pragma warning disable CS0809 // Obsolete member overrides non-obsolete member
        public override void Load()
#pragma warning restore CS0809 // Obsolete member overrides non-obsolete member
        {
            Bind<IMapper>().ToConstant(CreateConfiguration().CreateMapper()).InSingletonScope();
        }

        [Obsolete]
        private MapperConfiguration CreateConfiguration()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfiles(GetType().Assembly);
            });
            return config;
        }
    }
}