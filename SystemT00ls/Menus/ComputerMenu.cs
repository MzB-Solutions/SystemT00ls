using EasyConsole;
using SystemT00ls.CoreFunctions.PowerControl;

namespace SystemT00ls.Menus
{
    internal class ComputerMenu : MenuPage
    {
        #region Public Constructors

        public ComputerMenu(Program program)
            : base("Computer Behaviour", program,
                  new Option("Reboot", () => ExecuteControl.ExitWindows(RestartOptions.Reboot, true)),
                  new Option("Poweroff", () => ExecuteControl.ExitWindows(RestartOptions.PowerOff, true)),
                  new Option("Suspend", () => ExecuteControl.ExitWindows(RestartOptions.Suspend, true)),
                  new Option("Logoff", () => ExecuteControl.ExitWindows(RestartOptions.LogOff, true))
                       )
        {
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