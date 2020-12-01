using SManager.CoreLib.CommandFactory;

namespace SManager.CoreLib.System.Networking
{
    internal class Commands : Command
    {
        #region Public Constructors

        /// <summary>
        /// Inherited Command Receiver
        /// </summary>
        /// <param name="receiver"></param>
        public Commands(Receiver receiver) : base(receiver)
        {
        }

        #endregion Public Constructors

        #region Public Methods

        /// <summary>
        /// The Invoker execute command
        /// </summary>
        public override void Execute()
        {
            Receiver.Action();
        }

        #endregion Public Methods
    }
}