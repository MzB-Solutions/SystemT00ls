namespace SManager.Core.CommandFactory
{
    internal abstract class CommandBase
    {
        #region Public Properties

        public abstract string Name { get; set; }
        public abstract string Sender { get; set; }

        #endregion Public Properties

        #region Public Methods

        public abstract void Execute();

        #endregion Public Methods
    }
}