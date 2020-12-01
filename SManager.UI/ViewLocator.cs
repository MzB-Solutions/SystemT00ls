using Avalonia.Controls;
using Avalonia.Controls.Templates;
using System;
using SManager.UI.ViewModels;

namespace SManager.UI
{
    /// <summary>
    /// A simple ViewLocator four or MVVM implementation
    /// </summary>
    public class ViewLocator : IDataTemplate
    {
        #region Public Properties

        /// <summary>
        /// Can we receycle pages or not (DEFAULT: false)
        /// </summary>
        public bool SupportsRecycling => false;

        #endregion Public Properties

        #region Public Methods

        /// <summary>
        /// Basically find a view based on a viewmodels name and bind it into an instance of our ui app
        /// </summary>
        /// <param name="data">The ViewModel being passed into to find a View from</param>
        /// <returns>
        /// Either an instance of a Control object or a TextBlock indicating failure to load a view
        /// </returns>
        public IControl Build(object data)
        {
            string name = data.GetType().FullName.Replace("ViewModel", "View");
            Type type = Type.GetType(name);

            if (type != null)
            {
                return (Control)Activator.CreateInstance(type);
            }
            else
            {
                return new TextBlock { Text = "Not Found: " + name };
            }
        }

        /// <summary>
        /// a simple boolean matcher to figure out of data is of type ViewModelBase
        /// </summary>
        /// <param name="data">The class to check for ViewModel'ness</param>
        /// <returns>true or false, true when The object is based of ViewModelBase</returns>
        public bool Match(object data)
        {
            return data is ViewModelBase;
        }

        #endregion Public Methods
    }
}