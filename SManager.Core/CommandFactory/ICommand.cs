namespace SManager.Core.CommandFactory
{
    public interface ICommand
    {
        string GetName();

        void SetName(string value);

        bool IsPrimed { get; }

        void Execute();
    }
}