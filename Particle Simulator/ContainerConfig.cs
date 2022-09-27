using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace Particle_Simulator
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<App>().As<IApp>();
            builder.RegisterType<Simulation>().As<ISimulation>();
            //builder.RegisterAssemblyTypes(Assembly.Load(nameof(Class)))
            //    .Where(t=>t.Namespace.Contains("Folder"))
            //    .As(t=>t.GetInterfaces().FirstOrDefault(i=>i.Name == "I"+t.Name));

            return builder.Build();
        }
    }
}
