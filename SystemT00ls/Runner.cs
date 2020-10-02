namespace SystemT00ls
{
    internal class Runner
    {
        #region Private Methods

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "This is the apps entrypoint, it's always named Main()")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "Every app can take an argv type array")]
        private static void Main(string[] args)
        {
            new App().Run();
        }

        #endregion Private Methods
    }
}