namespace SManager.Core.CommandFactory
{
    /// <summary>
    /// The i command.
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <returns>A string.</returns>
        string GetName();

        /// <summary>
        /// Sets the name.
        /// </summary>
        /// <param name="value">The value.</param>
        void SetName(string value);

        /// <summary>
        /// Gets a value indicating whether is primed.
        /// </summary>
        bool IsPrimed { get; }

        /// <summary>
        /// Executes the.
        /// </summary>
        void Execute();
    }
}