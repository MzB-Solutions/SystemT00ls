namespace SManager.Core.CommandFactory
{
    internal class Command : CommandBase
    {
        #region Private Fields

        private string _name;
        private string _sender;

        #endregion Private Fields

        #region Public Properties

        public override string Name { get => _name; set => _name = value; }
        public override string Sender { get => _sender; set => _sender = value; }

        #endregion Public Properties

        #region Public Methods

        public override void Execute()
        {
            throw new System.NotImplementedException();
        }

        #endregion Public Methods
    }
}