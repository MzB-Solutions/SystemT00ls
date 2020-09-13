using EasyConsole;
using System;
using System.Collections.Generic;
using System.Text;

namespace SystemT00ls.Menus
{
    internal class MainMenu : MenuPage
    {
        #region Public Constructors

        public MainMenu(Program program)
            : base("SystemT00ls Main Menu", program,
                  new Option("Active Directory Tools", () => program.NavigateTo<ActiveDirectoryMenu>()),
                  new Option("Quit Application", () => program.NavigateHome()))
        { }

        #endregion Public Constructors
    }
}