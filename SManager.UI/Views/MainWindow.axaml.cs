using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace SystemT00ls.UI.Views
{
    /// <summary>
    /// The backend loader for the avalonia type xaml files.
    /// </summary>
    public class MainWindow : Window
    {
        #region Private Methods

        private void _initializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        #endregion Private Methods

        #region Public Constructors

        /// <summary>
        /// Our Constructor (will attach Avalonia DevTools when in DEBUG)
        /// </summary>
        public MainWindow()
        {
            _initializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        #endregion Public Constructors
    }
}