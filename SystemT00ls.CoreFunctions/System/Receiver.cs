namespace SystemT00ls.CoreFunctions.System
{
    /// <summary>
    /// A concrete implementation of a Receiver for the CommandFactory
    /// </summary>
    public partial class Receiver
    {
        #region Public Methods

        /// <summary>
        /// Run an action through the DommandFactory invoker
        /// </summary>
        public void Action()
        {
            switch (Networking.WhatCommand)
            {
                case 'r':
                    _ = new NetworkingFunctions().RenewIPs();
                    break;

                case 'f':
                    _ = new NetworkingFunctions().FlushDNSCache();
                    break;

                default:
                    break;
            }
        }

        #endregion Public Methods
    }
}