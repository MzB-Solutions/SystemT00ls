using SManager.Core.Logger;

namespace SManager.Core.CommandFactory
{
    public class Factory
    {
        public ICommand GetCommand(CommandSource source)
        {
            return source switch
            {
                CommandSource.logger => new LoggerCommand(),
                CommandSource.modules => null,
                _ => null,
            };
        }
    }
}