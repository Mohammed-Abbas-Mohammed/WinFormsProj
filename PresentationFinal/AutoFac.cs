
using Autofac;
using AutoMapper;
using DbCont;
using Infrastructure;
using MainAPP.Contracts;
using MainAPP.Mapp;
using MainAPP.SERVICES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddPro
{
    public class AutoFac
    {
        public static IContainer Inject()
        {
            var Builder = new ContainerBuilder();

            Builder.RegisterType<ProCon>().As<ProCon>();

            Builder.RegisterType<ProductServices>().As<IProductServices>();

            Builder.RegisterType<ProductRepository>().As<IProductRepo>();

             Builder.RegisterType<CategoryServices>().As<ICategoryServices>();

            Builder.RegisterType<CategoryRepository>().As<ICategoryRepo>();

            Builder.RegisterType<OrderServices>().As<IOrderServices>();

            Builder.RegisterType<OrderRepository>().As<IOrderRepo>();

            Builder.RegisterType<CustomerServices>().As<ICustomerServices>();

            Builder.RegisterType<CustomerRepository>().As<ICustomerRepo>();

            Builder.Register(c => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperPro>();
            }));

            Builder.Register(c => c.Resolve<MapperConfiguration>().CreateMapper(c.Resolve)).As<IMapper>().InstancePerLifetimeScope();

            return Builder.Build();
        }
    }
}