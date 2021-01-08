using SManager.Core.CommandFactory;

namespace SManager.Core
{
    public enum CommandSource
    {
        logger,
        modules
    }

    public class Program
    {
        private Settings settings;
        private string settingsJson;

        public Settings Settings { get => settings; set => settings = value; }
        public string SettingsJson { get => settingsJson; set => settingsJson = value; }

        public static ICommand BootstrapCommand(CommandSource cmdSource, string owner)
        {
            ICommand cmd = new Factory().GetCommand(cmdSource);
            cmd.SetName(owner);
            return cmd;
        }

        public Program()
        {
            Settings = new Settings();
            settingsJson = Settings.DUMP(Settings);
        }
    }
}