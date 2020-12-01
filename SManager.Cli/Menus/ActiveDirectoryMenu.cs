using EasyConsole;
using Microsoft.Extensions.Logging;
using System;

namespace SManager.Cli.Menus
{
    internal class ActiveDirectoryMenu : Page
    {
        #region Public Constructors

        /// <summary>
        /// Our ActiveDirectoryMenu Constructor
        /// </summary>
        /// <param name="program">An instance of our EasyConsole Menu</param>
        /// <param name="logger">Our App Logger</param>
        public ActiveDirectoryMenu(Program program, ILogger<App> logger)
            : base("Active Directory Tools", program)
        {
            logger.LogDebug($"ActiveDirectoryMenu built on : {DateTime.Now}");
        }

        #endregion Public Constructors

        #region Public Methods

        /// <summary>
        /// Put a notice out and after that return home.
        /// </summary>
        /// <remarks>This is an override from <see cref="EasyConsole.Page.Display">Display</see>.</remarks>
        public override void Display()
        {
            App.DoNotice("Under construction", 1, false, Notice.NoticeType.Message);
            base.Display();
            Output.WriteLine("List some tools here");
            Input.ReadString("Press [ENTER] to return to main menu");
            Program.NavigateHome();
        }

        #endregion Public Methods
    }
}