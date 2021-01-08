using SManager.Core.CommandFactory;
using System;

namespace SManager.Core.Logger
{
    public class LoggerCommand : ICommand
    {
        private string name;
        private bool isPrimed;

        public string GetName()
        {
            return name;
        }

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

        public bool IsPrimed { get => isPrimed; }

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