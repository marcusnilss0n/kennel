using Autofac;

namespace kennel
{
    class Program
    {
        static void Main()
        {
            // Run Autofac Configure
            var container = AFConfig.Configure();

            // Create an instance of IApplication since we are not using a constructor here
            using var scope = container.BeginLifetimeScope();
            var app = scope.Resolve<IApplication>();
            app.Run();
        }
    }
}
