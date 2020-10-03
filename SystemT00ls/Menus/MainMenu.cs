using EasyConsole;
using System;

namespace SystemT00ls.Menus
{
    internal class MainMenu : MenuPage
    {
        #region Public Constructors

        public MainMenu(Program program)
            : base("SystemT00ls", program,
                  new Option("Active Directory", () => program.NavigateTo<ActiveDirectoryMenu>()),
                  new Option("Docker4Windows", () => program.NavigateTo<DockerMenu>()),
                  new Option("Computer Behaviour", () => program.NavigateTo<ComputerMenu>()),
                  new Option("Quit Application", () => Environment.Exit(0)))
        { }

        #endregion Public Constructors

        #region Public Methods

        public override void Display()
        {
            App.DoNotice("This is beta-software!", 0, false, Notice.NoticeType.Warning, ConsoleColor.DarkBlue);
            base.Display();
        }

        #endregion Public Methods
    }
}