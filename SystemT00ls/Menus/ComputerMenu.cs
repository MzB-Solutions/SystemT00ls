using EasyConsole;
using SystemT00ls.CoreFunctions;

namespace SystemT00ls.Menus
{
    internal class ComputerMenu : MenuPage
    {
        #region Public Constructors

        public ComputerMenu(Program program)
            : base("Computer Behaviour", program,
                  new Option("Reboot", () => PowerControl.ExitWindows(RestartOptions.Reboot, true)),
                  new Option("Poweroff", () => PowerControl.ExitWindows(RestartOptions.PowerOff, true)),
                  new Option("Suspend", () => PowerControl.ExitWindows(RestartOptions.Suspend, true)),
                  new Option("Logoff", () => PowerControl.ExitWindows(RestartOptions.LogOff, true))
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