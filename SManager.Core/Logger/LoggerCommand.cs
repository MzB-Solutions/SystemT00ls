using SManager.Core.CommandFactory;
using System;

namespace SManager.Core.Logger
{
    public class LoggerCommand : ICommand
    {
        private string name;
        public string Name { get => name; set => name = value; }

        public void Execute()
        {
            Logger.DoLog($"Some message from \"{Name}\" ..");
        }
    }
}