using System;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;

namespace SManager.CoreLib.ActiveDirectory
{
    /// <summary>
    /// A simple AD query to grab some stuff
    /// </summary>
    public static class Users
    {
        #region Private Fields

        /// <summary>
        /// Departments
        /// </summary>
        private static List<object> deps = new List<object>();

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// The Users constructor, which simply grabs a bunch of AD entries atm...
        /// </summary>
        static Users()
        {
            CurrentUser = Environment.UserName.ToString();
            ActiveDirectoryDomain = Environment.GetEnvironmentVariable("USERDNSDOMAIN");
        }

        #endregion Public Constructors

        #region Public Properties

        /// <summary>
        /// The name of the domain we are connected to...
        /// </summary>
        public static string ActiveDirectoryDomain { get; private set; }

        /// <summary>
        /// The currently logged in User (in AD hopefullly)
        /// </summary>
        public static string CurrentUser { get; private set; }

        public static List<object> Departments { get => deps; set => deps = value; }

        #endregion Public Properties

        #region Public Methods

        /// <summary>
        /// Get the current user and return the login name assoicated with that account
        /// </summary>
        /// <returns>A simple string containing only the username</returns>
        public static string GetCurrentUser()
        {
            string returnValue;
            try
            {
                // enter AD settings
                PrincipalContext AD = new PrincipalContext(ContextType.Domain, ActiveDirectoryDomain);

                // create search user and add criteria
                UserPrincipal u = new UserPrincipal(AD)
                {
                    SamAccountName = CurrentUser
                };
                // search for user
                UserPrincipal result = (UserPrincipal)new PrincipalSearcher(u).FindOne();
                new PrincipalSearcher(u).Dispose();

                returnValue = result.SamAccountName;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                returnValue = string.Empty;
            }
            return returnValue;
        }

        #endregion Public Methods
    }
}