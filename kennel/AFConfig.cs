using Autofac;
using kennel.Animals;
using kennel.Customers;
using kennel.Data;
using kennel.MockDatas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace kennel
{
    public static class AFConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            // Register Main Application
            builder.RegisterType<Application>().As<IApplication>();

            // MockData
            builder.RegisterType<MockData>().As<IMockData>();

            // Data
            builder.RegisterType<DatabaseUsingLists>().As<IDatabaseUsingLists>().SingleInstance();

            // Repository
            builder.RegisterType<DataRepository>().As<IDataRepository>();

            // Menu
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(i => i.Namespace.Contains("Menu"))
                .AsImplementedInterfaces();

            // Animals            
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(i => i.Namespace.Contains("Animals"))
                .AsImplementedInterfaces();

            // Customers            
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(i => i.Namespace.Contains("Customers"))
                .AsImplementedInterfaces();

            return builder.Build();
        }
    }
}
