using System;
using System.Threading;
using static SystemT00ls.FunctionsType;
using static SystemT00ls.OurCursor;
using SystemT00ls.Menus;
using EasyConsole;

namespace SystemT00ls
{
    internal class App : Program
    {
        #region Private Fields

        private static Position _currentCursorPosition;
        private static Position _tempCursorPosition;

        private static bool isSubMenu;

        #endregion Private Fields

        #region Private Methods

        private static void _adMenu()
        {
            Console.WriteLine("*****************************");
            Console.WriteLine("*** Active Directory Menu ***");
            Console.WriteLine("*****************************");
            Console.WriteLine("*****************************");
            Console.WriteLine("*** 0) Return to root");
            isSubMenu = true;
        }

        private static void _compMenu()
        {
            Console.WriteLine("*******************************");
            Console.WriteLine("*** Computer Behaviour Menu ***");
            Console.WriteLine("*******************************");
            Console.WriteLine("*******************************");
            Console.WriteLine("*** 0) Return to root");
            isSubMenu = true;
        }

        private static void _dockerMenu()
        {
            Console.WriteLine("**************************");
            Console.WriteLine("*** Docker Daemon Menu ***");
            Console.WriteLine("**************************");
            Console.WriteLine("**************************");
            Console.WriteLine("*** 0) Return to root");
            isSubMenu = true;
        }

        private static void _mainMenu()
        {
            Console.WriteLine("******************************");
            Console.WriteLine("*** System Tools Main Menu ***");
            Console.WriteLine("******************************");
            Console.WriteLine();
            Console.WriteLine("*** 1) Active Directory Tools");
            Console.WriteLine("*** 2) Docker Tools");
            Console.WriteLine("*** 3) Computer Behaviour");
            Console.WriteLine("******************************");
            Console.WriteLine("*** 0) Exit this app");
            isSubMenu = false;
        }

        private static menuType _mainMenuSelection()
        {
            if (!int.TryParse(Console.ReadLine(), out int input))
            {
                _notice("MUST BE A NUMERICAL VALUE - TRY AGAIN", 2);
                input = 1;
            }
            else
            {
                if (input != 0)
                {
                    input++;
                }
            }
            return (menuType)input;
        }

        private static void _notice(string _noticeText, int _length)
        {
            var offsetX = -5;
            var offsetY = -2;
            _tempCursorPosition.X = Console.WindowWidth - _noticeText.Length + offsetX;
            _tempCursorPosition.Y = Console.WindowHeight + offsetY;
            Console.SetCursorPosition(_tempCursorPosition.X, _tempCursorPosition.Y);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(_noticeText);
            Console.ResetColor();
            Thread.Sleep(_length * 1000);
            _restorePosition();
        }

        /// <summary>
        /// print a menu from a selection of
        /// </summary>
        private static bool _printMenu(menuType type)
        {
            Console.Clear();
            switch (type)
            {
                case menuType.nullMenu:
                    if (isSubMenu)
                    {
                        _mainMenu();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case menuType.mainMenu:
                    _mainMenu();
                    return true;

                case menuType.dockerMenu:
                    _dockerMenu();
                    return true;

                case menuType.adMenu:
                    _adMenu();
                    return true;

                case menuType.compMenu:
                    _compMenu();
                    return true;

                default:
                    break;
            }
            _savePosition();
            return true;
        }

        private static void _restorePosition()
        {
            Console.SetCursorPosition(_currentCursorPosition.X, _currentCursorPosition.Y);
        }

        private static void _savePosition()
        {
            _currentCursorPosition.X = Console.CursorLeft;
            _currentCursorPosition.Y = Console.CursorTop;
        }

        //private static void Main(string[] args)
        //{
        //var myMenu = menuType.mainMenu;
        //while (_printMenu(myMenu))
        //{
        //    myMenu = _mainMenuSelection();
        //}
        //}

        #endregion Private Methods

        #region Public Constructors

        public App()
            : base("System Tools Application", breadcrumbHeader: true)
        {
            AddPage(new MainMenu(this));
            AddPage(new ActiveDirectoryMenu(this));
            SetPage<MainMenu>();
        }

        #endregion Public Constructors
    }
}