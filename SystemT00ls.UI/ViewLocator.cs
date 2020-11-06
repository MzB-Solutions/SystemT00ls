using Avalonia.Controls;
using Avalonia.Controls.Templates;
using System;
using SystemT00ls.UI.ViewModels;

namespace SystemT00ls.UI
{
    public class ViewLocator : IDataTemplate
    {
        #region Public Properties

        public bool SupportsRecycling => false;

        #endregion Public Properties

        #region Public Methods

        public IControl Build(object data)
        {
            var name = data.GetType().FullName.Replace("ViewModel", "View");
            var type = Type.GetType(name);

            if (type != null)
            {
                return (Control)Activator.CreateInstance(type);
            }
            else
            {
                return new TextBlock { Text = "Not Found: " + name };
            }
        }

        public bool Match(object data)
        {
            return data is ViewModelBase;
        }

        #endregion Public Methods
    }
}