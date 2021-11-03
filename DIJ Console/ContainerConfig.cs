using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIJLibrary;
using System.Reflection;

namespace DIJ_Console
{
    public class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<BusinessLogic>().As<IBusinessLogic>();
            builder.RegisterType<Application>().As<IApplication>();

            builder.RegisterAssemblyTypes(Assembly.Load(nameof(DIJLibrary)))
                .Where(t => t.Namespace.Contains("Utilities"))
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));

            return builder.Build();
        }
    }
}
