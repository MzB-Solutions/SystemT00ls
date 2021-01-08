using SManager.Core.CommandFactory;
using System;

namespace SManager.Core.Logger
{
    /// <summary>
    /// The logger command.
    /// </summary>
    public class LoggerCommand : ICommand
    {
        private string name;
        private bool isPrimed;

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <returns>A string.</returns>
        public string GetName()
        {
            return name;
        }

        /// <summary>
        /// Sets the name.
        /// </summary>
        /// <param name="value">The value.</param>
        public void SetName(string value)
        {
            if (value != name)
            {
                isPrimed = true;
                name = value;
            }
            else
            {
                isPrimed = false;
                name = String.Empty;
            }
        }

        /// <summary>
        /// Gets a value indicating whether is primed.
        /// </summary>
        public bool IsPrimed { get => isPrimed; }

        /// <summary>
        /// Executes the.
        /// </summary>
        public void Execute()
        {
            SManager.Core.Program core = new Program();
            string msg2 = core.SettingsJson;
            if (!IsPrimed)
            {
                Console.WriteLine($"The LoggerCommand is NOT primed!!");
            }
            else
            {
                Logger.DoLog($"Some message from \"{GetName()}\" ..");
                Logger.DoLog($"\"{GetName()}\": {msg2}");
            }
        }
    }
}