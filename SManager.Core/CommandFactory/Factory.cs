using SManager.Core.Logger;

namespace SManager.Core.CommandFactory
{
    /// <summary>
    /// The factory.
    /// </summary>
    public class Factory
    {
        /// <summary>
        /// Gets the command.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>An ICommand.</returns>
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