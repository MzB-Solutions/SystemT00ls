using EasyConsole;
using Microsoft.Extensions.Logging;
using System;
using SystemT00ls.CoreFunctions.System;

namespace SystemT00ls.cli.Menus
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
                      var StackInstance = new NetworkingFunctions();
                      var returnCode = StackInstance.FlushDNSCache();
                      logger.LogDebug($"#{DateTime.Now}#: FLushing the DNS resolvers resulted in the following return code: {returnCode}");
                      logger.LogDebug(Networking.LogMessage);
                      program.NavigateTo<NetworkingMenu>();
                  }),

                  new Option("Renew IP Address", () =>
                  {
                      var StackInstance = new NetworkingFunctions();
                      var returnCode = StackInstance.RenewIPs();
                      logger.LogDebug($"#{DateTime.Now}#: Renewing the IP address(es) resulted in the following return code: {returnCode}");
                      logger.LogDebug(Networking.LogMessage);
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