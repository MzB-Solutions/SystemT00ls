using System;

namespace SManager.Core.Logger
{
    public class Logger
    {
        public static void DoLog(string message)
        {
            Console.WriteLine($"The following message was logged: {message}");
        }
    }
}