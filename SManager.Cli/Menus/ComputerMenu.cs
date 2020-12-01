using EasyConsole;
using Microsoft.Extensions.Logging;
using System;
using SManager.CoreLib.System.Power;

namespace SManager.cli.Menus
{
    internal class ComputerMenu : MenuPage
    {
        #region Public Constructors

        public ComputerMenu(Program program, ILogger<App> logger)
            : base("Computer Behaviour", program,
                  new Option("Networking", () => program.NavigateTo<NetworkingMenu>()),
                  new Option("Reboot", () => Control.ExitWindows(RestartOptions.Reboot, true)),
                  new Option("Poweroff", () => Control.ExitWindows(RestartOptions.PowerOff, true)),
                  new Option("Suspend", () => Control.ExitWindows(RestartOptions.Suspend, true)),
                  new Option("Logoff", () => Control.ExitWindows(RestartOptions.LogOff, true))
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