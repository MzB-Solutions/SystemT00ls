using System;

namespace SystemT00ls
{
    enum menuType
    {
        nullMenu = 0,
        mainMenu = 1,
        adMenu = 2
    };
    enum availableTools
    {
        nullTool = 0,
        adTools = 1,
        dockerTools = 2
    };
    class Program
    {
        static void adMenu()
        {
            Console.WriteLine("*****************************");
            Console.WriteLine("*** Active Directory Menu ***");
            Console.WriteLine("*****************************");
        }

        static void mainMenu()
        {
            Console.WriteLine("******************************");
            Console.WriteLine("*** System Tools Main Menu ***");
            Console.WriteLine("******************************");
            Console.WriteLine();
            Console.WriteLine("*** 1) Active Directory Tools");
            Console.WriteLine("*** 2) Docker Tools");
            mainMenuSelection();
        }

        static int mainMenuSelection()
        {
            var input = (int)Console.ReadKey().Key;
            return input;
        }
        /// <summary>
        /// print a menu from a selection of 
        /// </summary>
        static void _printMenu(menuType type)
        {
            switch (type)
            {
                case menuType.nullMenu:
                    break;
                case menuType.mainMenu:
                    mainMenu();
                    break;
                case menuType.adMenu:
                    break;
                default:
                    break;
            }
        }

        static void Main(string[] args)
        {
            Console.Clear();
            _printMenu(menuType.mainMenu);
            int next = mainMenuSelection();
            Console.WriteLine(next);
        }
    }
}
