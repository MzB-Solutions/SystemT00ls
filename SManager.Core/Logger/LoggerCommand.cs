using SManager.Core.CommandFactory;

namespace SManager.Core.Logger
{
    public class LoggerCommand : Command
    {
        #region Public Constructors

        public LoggerCommand(Receiver _receiver) : base(_receiver, "Logger")
        {
        }

        #endregion Public Constructors

        #region Public Properties

        public override string Name { get; }

        #endregion Public Properties

        #region Public Methods

        public override void Execute()
        {
            Receiver.Action();
        }

        #endregion Public Methods
    }
}