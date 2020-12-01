using EasyConsole;
using Microsoft.Extensions.Logging;
using System;
using SManager.CoreLib.System.Networking;

namespace SManager.cli.Menus
{
    internal class NetworkingMenu : MenuPage
    {
        #region Public Constructors

        /// <summary>
        /// NetworkingMenu COnstructor
        /// </summary>
        /// <param name="program">Pass an instance of EasyCOnsole in to handle the menu build</param>
        /// <param name="logger">Our App logger</param>
        public NetworkingMenu(Program program, ILogger<App> logger)
            : base("Networking Tools", program,
                  new Option("Flush DNS Resolvers", () =>
                  {
                      Functions StackInstance = new Functions();
                      uint returnCode = StackInstance.FlushDNSCache();
                      logger.LogDebug($"#{DateTime.Now}#: Flushing the DNS resolvers resulted in the following return code: {returnCode}");
                      logger.LogDebug(Networking.LogMessage);
#if DEBUG
                      logger.LogCritical($"#{DateTime.Now}#: Flushing the DNS resolvers resulted in the following return code: {returnCode}");
                      logger.LogCritical(Networking.LogMessage);
#endif
                      program.NavigateTo<NetworkingMenu>();
                  }),

                  new Option("Renew IP Address", () =>
                  {
                      Functions StackInstance = new Functions();
                      bool returnCode = StackInstance.RenewIPs();
                      logger.LogDebug($"#{DateTime.Now}#: Renewing the IP address(es) resulted in the following return code: {returnCode}");
                      logger.LogDebug(Networking.LogMessage);
#if DEBUG
                      logger.LogCritical($"#{DateTime.Now}#: Renewing the IP address(es) resulted in the following return code: {returnCode}");
                      logger.LogCritical(Networking.LogMessage);
#endif

                      program.NavigateTo<NetworkingMenu>();
                  })
                  )
        {
            logger.LogDebug($"NetworkingMenu built on : {DateTime.Now}");
        }

        #endregion Public Constructors

        #region Public Methods

        public override void Display()
        {
            base.Display();
        }

        #endregion Public Methods
    }
}