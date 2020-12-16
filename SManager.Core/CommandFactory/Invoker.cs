namespace SManager.Core.CommandFactory
{
    internal class Invoker
    {
        #region Private Properties

        private Command Command { get; set; }

        #endregion Private Properties

        #region Public Constructors

        public Invoker(Command _command)
        {
            Command = _command;
        }

        #endregion Public Constructors

        #region Public Methods

        public void ExecuteCommand()
        {
            Command.Execute();
        }

        #endregion Public Methods
    }
}