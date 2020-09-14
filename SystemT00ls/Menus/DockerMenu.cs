using EasyConsole;

namespace SystemT00ls.Menus
{
    internal class DockerMenu : Page
    {
        #region Public Constructors

        public DockerMenu(Program program)
            : base("Docker Tools", program)
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