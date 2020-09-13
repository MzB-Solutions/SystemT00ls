namespace SystemT00ls
{
    internal class OurCursor
    {
        #region Public Structs

        public struct Position
        {
            #region Private Fields

            private int _X;
            private int _Y;

            #endregion Private Fields

            #region Public Properties

            public int X { get => _X; set => _X = value; }
            public int Y { get => _Y; set => _Y = value; }

            #endregion Public Properties
        }

        #endregion Public Structs
    }
}