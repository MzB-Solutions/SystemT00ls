using EasyConsole;
using SystemT00ls.CoreFunctions;

namespace SystemT00ls.Menus
{
    internal class ComputerMenu : MenuPage
    {
        #region Public Constructors

        public ComputerMenu(Program program)
            : base("Computer Behaviour", program,
                  new Option("Reboot in 10 Seconds", () => Reboot.RestartComputer()),
                  new Option("Shutdown and poweroff the Computer", () => Reboot.ShutdownComputer()),
                  new Option("Logoff User", () => Reboot.LogoffUser())
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