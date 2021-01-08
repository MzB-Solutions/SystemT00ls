using System;

namespace SManager.Core.Logger
{
    /// <summary>
    /// The logger.
    /// </summary>
    public class Logger
    {
        /// <summary>
        /// Dos the log.
        /// </summary>
        /// <param name="message">The message.</param>
        public static void DoLog(string message)
        {
            Console.WriteLine($"The following message was logged: {message}");
        }
    }
}