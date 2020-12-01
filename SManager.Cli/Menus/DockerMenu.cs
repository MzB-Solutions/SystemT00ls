using EasyConsole;
using Microsoft.Extensions.Logging;
using System;

namespace SystemT00ls.cli.Menus
{
    internal class DockerMenu : Page
    {
        #region Public Constructors

        /// <summary>
        /// DockerMenu Constructor
        /// </summary>
        /// <param name="program">an instance of our DockerMenu EasuyConsole</param>
        /// <param name="logger">The app logger to log events and failures to.</param>
        public DockerMenu(Program program, ILogger<App> logger)
            : base("Docker Tools", program)
        {
            logger.LogDebug($"DockerMenu built on : {DateTime.Now}");
        }

        #endregion Public Constructors

        #region Public Methods

        /// <summary>
        /// Put a notice out and after that return home.
        /// </summary>
        /// <remarks>This is an override from <see cref="EasyConsole.Page.Display">Display</see>.</remarks>
        public override void Display()
        {
            App.DoNotice("Under construction", 1, true, Notice.NoticeType.Message);
            base.Display();
            Output.WriteLine("List some tools here");
            Input.ReadString("Press [ENTER] to return to main menu");
            Program.NavigateHome();
        }

        #endregion Public Methods
    }
}