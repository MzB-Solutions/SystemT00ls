using SystemT00ls.CoreFunctions.CommandFactory;

namespace SystemT00ls.CoreFunctions.System.Commands
{
    internal class NetworkingCommands : Command
    {
        #region Public Constructors

        /// <summary>
        /// Inherited Command Receiver
        /// </summary>
        /// <param name="receiver"></param>
        public NetworkingCommands(Receiver receiver) : base(receiver)
        {
        }

        #endregion Public Constructors

        #region Public Methods

        /// <summary>
        /// The Invoker execute command
        /// </summary>
        public override void Execute() => Receiver.Action();

        #endregion Public Methods
    }
}