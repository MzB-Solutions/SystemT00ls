using EasyConsole;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;
using SystemT00ls.cli.Menus;
using SystemT00ls.CoreFunctions.ActiveDirectory;
using SystemT00ls.CoreFunctions.Configuration;
using static SystemT00ls.cli.Notice;

namespace SystemT00ls.cli
{
    internal class App : Program
    {
        #region Private Fields

        private readonly AppConfig _appConfig;
        private readonly ILogger<App> _logger;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// Construct the menu order
        /// </summary>
        public App(IOptions<AppConfig> appConfig, ILogger<App> logger)
            : base("System Tools Application", breadcrumbHeader: true)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            AddPage(new MainMenu(this, logger));
            AddPage(new ActiveDirectoryMenu(this, logger));
            AddPage(new DockerMenu(this, logger));
            AddPage(new ComputerMenu(this, logger));
            AddPage(new NetworkingMenu(this, logger));
            SetPage<MainMenu>();
            _appConfig = appConfig?.Value ?? throw new ArgumentNullException(nameof(appConfig));
        }

        #endregion Public Constructors

        #region Public Methods

        /// <summary>
        /// A public wrapper for the _notice() function
        /// </summary>
        /// <param name="Text">What text to display as a notice</param>
        /// <param name="length">
        /// Length of seconds to wait before we return control (Any positive non-null integer)
        /// </param>
        /// <param name="cleanMe">Do we cleanup our own message? (Default: true)</param>
        /// <param name="color">
        /// This is essentially an enum of warning levels, converted to a
        /// <seealso cref="ConsoleColor" /> (Default: NoticeType.Error =&gt; Red)
        /// </param>
        /// <param name="bgcolor">Any valid <see cref="ConsoleColor" /> (Default: ConsoleColor.Black)</param>
        public static void DoNotice(string Text, byte length, bool cleanMe = true, NoticeType color = NoticeType.Error, ConsoleColor bgcolor = ConsoleColor.Black)
        {
            _ = new Notice(Text, cleanMe, color, length, bgcolor);
        }

        public async Task RunMe(string[] args)
        {
            _logger.LogInformation($"Starting {_appConfig.AppName} v{_appConfig.AppVersion}...");
            _logger.LogInformation($"Application Configuration: {args}");
            _logger.LogInformation($"Current User: {Users.GetCurrentUser()}");
            base.Run();
            _logger.LogInformation($"Closing {_appConfig.AppName} v{_appConfig.AppVersion}...");
            await Task.CompletedTask;
        }

        #endregion Public Methods
    }
}