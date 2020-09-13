using EasyConsole;
using System;
using System.Collections.Generic;
using System.Text;

namespace SystemT00ls.Menus
{
    internal class ActiveDirectoryMenu : Page
    {
        #region Public Constructors

        public ActiveDirectoryMenu(Program program)
            : base("Active Directory Tools", program)
        {
        }

        #endregion Public Constructors

        #region Public Methods

        public override void Display()
        {
            base.Display();
            Output.WriteLine("List some tools here");
            Input.ReadString("Press [ENTER] to return to main menu");
            Program.NavigateHome();
        }

        #endregion Public Methods
    }
}