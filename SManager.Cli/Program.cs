using System;

namespace SManager.Cli
{
    internal class Program
    {
        #region Private Methods

        private static void Main(string[] _args)
        {
            Console.WriteLine("Hello World!");
            if (_args.Length <= 1) { }
            else
            {
            }
            var cmdLogger = Core.Program.BootstrapCommand(Core.CommandSource.logger, "SManager.Cli");
            if (cmdLogger.IsPrimed)
            {
                cmdLogger.Execute();
            }
            else
            {
                Console.WriteLine("The logger wasnt primed correctly");
            }

            _ = Console.ReadKey();
        }

        #endregion Private Methods
    }
}