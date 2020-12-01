using EasyConsole;
using Microsoft.Extensions.Logging;
using System;

namespace SManager.cli.Menus
{
    internal class MainMenu : MenuPage
    {
        #region Public Constructors

        public MainMenu(Program program, ILogger<App> logger)
            : base("SManager", program,
                  new Option("Active Directory", () => program.NavigateTo<ActiveDirectoryMenu>()),
                  new Option("Docker4Windows", () => program.NavigateTo<DockerMenu>()),
                  new Option("Computer Behaviour", () => program.NavigateTo<ComputerMenu>()),
                  new Option("Quit Application", () => Environment.Exit(0)))
        {
            logger.LogDebug($"MainMenu built on : {DateTime.Now}");
        }

        #endregion Public Constructors

        #region Public Methods

        public override void Display()
        {
            App.DoNotice("This is beta-software!", 0, false, Notice.NoticeType.Info, ConsoleColor.DarkBlue);
            base.Display();
        }

        #endregion Public Methods
    }
}