using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.IO;
using System.Threading.Tasks;
using SystemT00ls.CoreLib.Configuration;

namespace SystemT00ls.cli
{
    internal class Runner
    {
        #region Private Methods

        private static void _configureServices(IServiceCollection _services)
        {
            // configure logging
            _ = _services.AddLogging(builder =>
              {
#if DEBUG
                  builder.AddConsole();
#endif
                  builder.AddDebug();
              });

            // build config
            _ = _services.Configure<AppConfig>(new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables()
                .Build().GetSection("Application"));

            // add services: services.AddTransient<IMyRespository, MyConcreteRepository>();

            // add app
            _ = _services.AddTransient<App>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "This is the apps entrypoint, it's always named Main()")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "Every app can take an argv type array")]
        private static async Task Main(string[] args)
        {
            // create service collection
            var services = new ServiceCollection();
            _configureServices(services);

            // create service provider
            var serviceProvider = services.BuildServiceProvider();

            // entry to run app
            await serviceProvider.GetService<App>().RunMe(args);
            //new App().RunMe();
            //Console.WriteLine(_appSettings.TempDirectory);
        }

        #endregion Private Methods
    }
}