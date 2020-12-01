namespace SystemT00ls.CoreLib.Configuration
{
    /// <summary>
    /// A simple Application Configuration with just 2 fields
    /// </summary>
    public class AppConfig
    {
        #region Public Properties

        /// <summary>
        /// Application Name
        /// </summary>
        public string AppName { get; set; }

        /// <summary>
        /// Application Version
        /// </summary>
        public string AppVersion { get; set; }

        #endregion Public Properties
    }
}