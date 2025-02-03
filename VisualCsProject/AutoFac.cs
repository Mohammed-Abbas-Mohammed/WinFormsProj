
using Autofac;
using AutoMapper;
using DbCont;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainAPP.SERVICES;
using MainAPP.Contracts;
using MainAPP.Mapp;

namespace AddPro
{
    public class AutoFacCopy
    {
        public static IContainer Inject()
        {
            var Builder = new ContainerBuilder();

            Builder.RegisterType<ProCon>().As<ProCon>();

            Builder.RegisterType<ProductServices>().As<IProductServices>();

            Builder.RegisterType<ProductRepository>().As<IProductRepo>();

            Builder.Register(c => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperPro>();
            }));

            Builder.Register(c => c.Resolve<MapperConfiguration>().CreateMapper(c.Resolve)).As<IMapper>().InstancePerLifetimeScope();

            return Builder.Build();
        }
    }
}