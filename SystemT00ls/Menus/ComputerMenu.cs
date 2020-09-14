using EasyConsole;
using SystemT00ls.CoreFunctions;

namespace SystemT00ls.Menus
{
    internal class ComputerMenu : MenuPage
    {
        #region Public Constructors

        public ComputerMenu(Program program)
            : base("Computer Behaviour", program,
                  new Option("Reboot in 10 Seconds", () => CoreFunctions.Reboot.RestartComputer())
                       )
        {
        }

        #endregion Public Constructors
    }
}