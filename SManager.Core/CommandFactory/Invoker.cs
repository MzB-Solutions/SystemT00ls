namespace SManager.Core.CommandFactory
{
    internal class Invoker
    {
        #region Private Fields

        private readonly Command _cmd;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// Invoker Constructor
        /// </summary>
        /// <param name="command">Passes in the command to run</param>
        public Invoker(Command command)
        {
            _cmd = command;
        }

        #endregion Public Constructors

        #region Public Methods

        /// <summary>
        /// The inherited Execute command
        /// </summary>
        public void ExecuteCommand()
        {
            _cmd.Execute();
        }

        #endregion Public Methods
    }
}