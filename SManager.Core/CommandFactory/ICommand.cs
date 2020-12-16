namespace SManager.Core.CommandFactory
{
    internal interface ICommand
    {
        #region Public Properties

        public string Name { get; }

        #endregion Public Properties

        #region Public Methods

        void Execute();

        #endregion Public Methods
    }
}