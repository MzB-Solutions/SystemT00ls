namespace SManager.CoreLib.System.Networking
{
    /// <summary>
    /// a simple stack of networking functions
    /// </summary>
    public class Networking
    {
        #region Private Fields

        private Receiver receiver;

        #endregion Private Fields

        #region Public Properties

        /// <summary>
        /// In case we have errormessage cropping up, they're in here
        /// </summary>
        public static string LogMessage { get; set; }

        /// <summary>
        /// This should either contain 'r'refresh or 'f'lushdns
        /// </summary>
        public static char WhatCommand { get; set; }

        /// <summary>
        /// an instance of a command receiver that listens to the invoke/execute commands
        /// </summary>
        public Receiver Receiver { get => receiver; set => receiver = value; }

        #endregion Public Properties
    }
}