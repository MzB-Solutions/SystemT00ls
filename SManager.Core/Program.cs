using SManager.Core.CommandFactory;

namespace SManager.Core
{
    public enum CommandSource
    {
        logger,
        modules
    }

    public class Program
    {
        public static ICommand bootstrapCommand(string commandSource, string source)
        {
            ICommand cmd = new Factory().GetCommand(commandSource);
            cmd.Name = source;
            return cmd;
        }
    }
}