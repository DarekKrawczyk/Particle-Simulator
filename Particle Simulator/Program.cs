using Autofac;

namespace Particle_Simulator
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            IContainer container = ContainerConfig.Configure();
            using (ILifetimeScope scope = container.BeginLifetimeScope())
            {
                IApp app = scope.Resolve<IApp>();
                app.run();
            }
            //App app = new App();
            ////.Windows.Forms.Application.Run(app);
            //app.Close();
        }
    }
}