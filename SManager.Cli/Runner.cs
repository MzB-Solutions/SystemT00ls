using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SManager.CoreLib.Configuration;
using System.IO;
using System.Threading.Tasks;

namespace SManager.cli
{
    internal class Runner
    {
        #region Private Methods

        private static void _configureServices(IServiceCollection _services)
        {
            _services.AddLogging(builder =>
              {
#if DEBUG
                  builder.AddConsole();
                  builder.AddDebug();
#endif
                  builder.AddSentry("https://24ee821a095642999a8a13692aae9a43@o253741.ingest.sentry.io/5508609");
              });

            // build config
            _services.Configure<AppConfig>(new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables()
                .Build().GetSection("Application"));

            // add services: services.AddTransient<IMyRespository, MyConcreteRepository>();

            // add app
            _services.AddTransient<App>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "This is the apps entrypoint, it's always named Main()")]
        private static async Task Main(string[] args)
        {
            // create service collection
            ServiceCollection services = new ServiceCollection();
            _configureServices(services);

            // create service provider
            ServiceProvider serviceProvider = services.BuildServiceProvider();

            // entry to run app
            await serviceProvider.GetService<App>().RunMe(args);
            //new App().RunMe();
            //Console.WriteLine(_appSettings.TempDirectory);
        }

        #endregion Private Methods
    }
}