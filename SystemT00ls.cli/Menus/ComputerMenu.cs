using EasyConsole;
using Microsoft.Extensions.Logging;
using System;
using SystemT00ls.CoreFunctions.PowerControl;

namespace SystemT00ls.cli.Menus
{
    internal class ComputerMenu : MenuPage
    {
        #region Public Constructors

        public ComputerMenu(Program program, ILogger<App> logger)
            : base("Computer Behaviour", program,
                  new Option("Networking", () => program.NavigateTo<NetworkingMenu>()),
                  new Option("Reboot", () => ExecuteControl.ExitWindows(RestartOptions.Reboot, true)),
                  new Option("Poweroff", () => ExecuteControl.ExitWindows(RestartOptions.PowerOff, true)),
                  new Option("Suspend", () => ExecuteControl.ExitWindows(RestartOptions.Suspend, true)),
                  new Option("Logoff", () => ExecuteControl.ExitWindows(RestartOptions.LogOff, true))
                       )
        {
            logger.LogDebug($"ComputerMenu built on : {DateTime.Now}");
        }

        #endregion Public Constructors

        #region Public Methods

        public override void Display()
        {
            App.DoNotice("No prompts will be given for any of the above commands!", 2, false, Notice.NoticeType.Error);
            base.Display();
        }

        #endregion Public Methods
    }
}