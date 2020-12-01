using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace SManager.CoreLib.System.Networking
{
    /// <summary>
    /// A simple networking stack, that allows us to run some rudementary functions on Windows'
    /// networking stack
    /// </summary>
    public partial class Functions
    {
        #region Private Methods

        [DllImport("dnsapi.dll", EntryPoint = "DnsFlushResolverCache")]
        private static extern uint _dnsFlushResolverCache();

        /// <summary>
        /// A hacky way to release and renew a dhcp lease
        /// </summary>
        /// <param name="_operation">'r' for release and 'n' for reNew IP</param>
        /// <param name="_result">Should return 0 if all went well</param>
        private void _renewIpAddresses(char _operation, out int _result)
        {
            string arg = _operation switch
            {
                'r' => "/C ipconfig /release",
                'n' => "/C ipconfig /renew",
                _ => string.Empty,
            };
            _result = -255;
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                WindowStyle = ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                Arguments = arg
            };
            if (arg != string.Empty)
            {
                Process process = new Process
                {
                    StartInfo = startInfo
                };
                try
                {
                    process.Start();
                }
                catch (ObjectDisposedException myException)
                {
                    Networking.LogMessage = $"An Exception occured in [networking]: {myException.Message}";
                    _result = -1;
                    throw new Exception($"An Exception occured in [networking]: {myException.Message}", myException);
                }
                catch (InvalidOperationException myException)
                {
                    Networking.LogMessage = $"An Exception occured in [networking]: {myException.Message}";
                    _result = -1;
                    throw new Exception($"An Exception occured in [networking]: {myException.Message}", myException);
                }
                catch (PlatformNotSupportedException myException)
                {
                    Networking.LogMessage = $"An Exception occured in [networking]: {myException.Message}";
                    _result = -1;
                    throw new Exception($"An Exception occured in [networking]: {myException.Message}", myException);
                }
                finally
                {
                    Networking.LogMessage = "Process started!";
                    _result = process.ExitCode;
                }
            }
        }

        private bool _runRenew()
        {
            bool ok;
            _renewIpAddresses(RenewCmd, out int errorCode);

            if (errorCode == -1)
            {
                Networking.LogMessage = $"#{DateTime.Now}#: An exception was thrown and returned the following errorcode: {errorCode}";
                ok = false;
            }
            else if (errorCode == -255)
            {
                Networking.LogMessage = $"#{DateTime.Now}#: The process runner could not be initialized and returned the following errorcode: {errorCode}";
                ok = false;
            }
            else
            {
                Networking.LogMessage = $"#{DateTime.Now}#: Looks like it ran.. the command returned: {errorCode}";
                ok = true;
            }
            return ok;
        }

        #endregion Private Methods

        #region Internal Fields

        internal char RenewCmd;

        #endregion Internal Fields

        #region Public Constructors

        /// <summary>
        /// NetworkingFunctions(?) Constuctor
        /// </summary>
        public Functions()
        {
            switch (Networking.WhatCommand)
            {
                case 'r':
                    RenewIPs();
                    break;

                case 'f':
                    FlushDNSCache();
                    break;

                default:
                    break;
            }
        }

        #endregion Public Constructors

        #region Public Methods

        /// <summary>
        /// Simple call into dnsapi.dll and call <see cref="_dnsFlushResolverCache">_dnsFlushResolverCache</see>
        /// </summary>
        /// <returns>and integer result, 0 if all good.</returns>
        public uint FlushDNSCache()
        {
            uint result = _dnsFlushResolverCache();
            Networking.LogMessage = $"#{DateTime.Now}#: Flushed the dns resolver cache via dnsapi.dll";
            return result;
        }

        /// <summary>
        /// Simply call a new cmd instance to ipconfig /release + ipconfig /renew
        /// </summary>
        /// <param name="timeout">a millisecond amount to wait for (DEFAULT: 2000 = 2 seconds)</param>
        /// <returns>A return code of 0 indicates success, and 1 a failure.</returns>
        /// <remarks>We should really thread this and await its outcome</remarks>
        public bool RenewIPs(int timeout = 2000)
        {
            RenewCmd = 'r';
            string strResult;
            if (_runRenew())
            {
                Thread.Sleep(timeout);
                strResult = "0";
            }
            else
            {
                strResult = "1";
            }
            RenewCmd = 'n';
            if (_runRenew())
            {
                Thread.Sleep(timeout);
                strResult = "0";
            }
            else
            {
                strResult = "1";
            }
            _ = bool.TryParse(strResult, out bool result);
            return result;
        }

        #endregion Public Methods
    }
}