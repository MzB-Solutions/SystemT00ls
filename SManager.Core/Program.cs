using SManager.Core.CommandFactory;

namespace SManager.Core
{
    /// <summary>
    /// The command source.
    /// </summary>
    public enum CommandSource
    {
        logger,
        modules
    }

    /// <summary>
    /// The program.
    /// </summary>
    public class Program
    {
        private Settings settings;
        private string settingsJson;

        /// <summary>
        /// Gets or sets the settings.
        /// </summary>
        public Settings Settings { get => settings; set => settings = value; }

        /// <summary>
        /// Gets or sets the settings json.
        /// </summary>
        public string SettingsJson { get => settingsJson; set => settingsJson = value; }

        /// <summary>
        /// Bootstraps the command.
        /// </summary>
        /// <param name="cmdSource">The cmd source.</param>
        /// <param name="owner">The owner.</param>
        /// <returns>An ICommand.</returns>
        public static ICommand BootstrapCommand(CommandSource cmdSource, string owner)
        {
            ICommand cmd = new Factory().GetCommand(cmdSource);
            cmd.SetName(owner);
            return cmd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Program" /> class.
        /// </summary>
        public Program()
        {
            Settings = new Settings();
            settingsJson = Settings.DUMP();
        }
    }
}