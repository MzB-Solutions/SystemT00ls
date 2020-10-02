using EasyConsole;
using System;
using SystemT00ls.Menus;
using static SystemT00ls.Notice;

namespace SystemT00ls
{
    internal class App : Program
    {
        #region Public Constructors

        /// <summary>
        /// Construct the menu order
        /// </summary>
        public App()
            : base("System Tools Application", breadcrumbHeader: true)
        {
            AddPage(new MainMenu(this));
            AddPage(new ActiveDirectoryMenu(this));
            AddPage(new DockerMenu(this));
            AddPage(new ComputerMenu(this));
            SetPage<MainMenu>();
        }

        #endregion Public Constructors

        #region Public Methods

        /// <summary>
        /// A public wrapper for the _notice() function
        /// </summary>
        /// <param name="Text">What text to display as a notice</param>
        /// <param name="length">Length of seconds to wait before we return control</param>
        /// <param name="cleanMe">Do we cleanup our own message? (Default: true)</param>
        /// <param name="color">This is essentially an enum of warning levels, converted to a <seealso cref="ConsoleColor"/></param>
        public static void DoNotice(string Text, int length, bool cleanMe = true, NoticeType color = NoticeType.Error)
        {
            _ = new Notice(Text, length, cleanMe, color);
        }

        #endregion Public Methods
    }
}