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
        public static ICommand BootstrapCommand(CommandSource cmdSource, string owner)
        {
            ICommand cmd = new Factory().GetCommand(cmdSource);
            cmd.SetName(owner);
            return cmd;
        }
    }
}