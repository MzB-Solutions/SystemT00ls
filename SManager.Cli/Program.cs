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
                _ = Console.ReadKey();
            }
        }

        #endregion Private Methods
    }
}