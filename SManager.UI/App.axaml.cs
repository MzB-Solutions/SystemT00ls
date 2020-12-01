using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using SystemT00ls.UI.ViewModels;
using SystemT00ls.UI.Views;

namespace SystemT00ls.UI
{
    /// <summary>
    /// Avalonia Bootstrap
    /// </summary>
    public class App : Application
    {
        #region Public Methods

        /// <summary>
        /// Let's load our xaml files
        /// </summary>
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        /// <summary>
        /// Ensure the mainwindow gets intialized and bound
        /// </summary>
        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new MainWindow
                {
                    DataContext = new MainWindowViewModel(),
                };
            }

            base.OnFrameworkInitializationCompleted();
        }

        #endregion Public Methods
    }
}