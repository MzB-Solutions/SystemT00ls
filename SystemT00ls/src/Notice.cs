using EasyConsole;
using System;
using System.Threading;
using static SystemT00ls.OurCursor;

namespace SystemT00ls
{
    internal class Notice
    {
        #region Public Enums

        public enum NoticeType
        {
            Info = ConsoleColor.White,
            Warning = ConsoleColor.Yellow,
            Error = ConsoleColor.Red,
            Message = ConsoleColor.Green
        }

        #endregion Public Enums

        #region Private Fields

        /// <summary>
        /// a struct of 2 ints for X and Y position of the (current) cursor
        /// </summary>
        private static Position _currentCursorPosition;

        /// <summary>
        /// a struct of 2 ints for X and Y positions of the temp/notice cursor
        /// </summary>
        private static Position _tempCursorPosition;

        #endregion Private Fields

        #region Private Methods

        /// <summary>
        /// Display a notice, somewhere near the bottom in red
        /// </summary>
        /// <param name="_noticeText">A string containing the message to display</param>
        /// <param name="_length">The length of time (in seconds) to wait, to reset the cursor</param>
        /// <param name="_cleanMe">Are we cleaning up after ourselves (true) or do we put a message at the bottom and leave it there (false)?</param>
        /// <param name="color">This is actually an enum <seealso cref="NoticeType"/></param>
        public Notice(string _noticeText, int _length, bool _cleanMe, NoticeType color)
        {
            _savePosition();
            var offsetX = -5;
            var offsetY = -2;
            string _prefix;
            switch (color)
            {
                case NoticeType.Info:
                    _prefix = "Information: ";
                    offsetX -= _prefix.Length;
                    break;

                case NoticeType.Warning:
                    _prefix = "Warning: ";
                    offsetX -= _prefix.Length;
                    break;

                case NoticeType.Error:
                    _prefix = "ERROR: ";
                    offsetX -= _prefix.Length;
                    break;

                case NoticeType.Message:
                    _prefix = "Notice: ";
                    offsetX -= _prefix.Length;
                    break;

                default:
                    _prefix = "";
                    break;
            }
            _tempCursorPosition.X = Console.WindowWidth
                        - _noticeText.Length
                        + offsetX;
            _tempCursorPosition.Y = Console.WindowHeight
                                    + offsetY;
            Console.SetCursorPosition(_tempCursorPosition.X, _tempCursorPosition.Y);
            Output.WriteLine((ConsoleColor)color, "{1}{0}", _noticeText, _prefix);
            if (_cleanMe)
            {
                Thread.Sleep(_length * 1000);
                Console.SetCursorPosition(_tempCursorPosition.X, _tempCursorPosition.Y);
                Output.WriteLine(ConsoleColor.Black, "{1}{0}", _noticeText, _prefix);
            }
            _restorePosition();
        }

        /// <summary>
        /// Simply restore the cursor position from the private var _currentCursorPosition
        /// </summary>
        private static void _restorePosition()
        {
            Console.SetCursorPosition(_currentCursorPosition.X, _currentCursorPosition.Y);
        }

        /// <summary>
        /// save the current console position into _currentCursorPositon
        /// </summary>
        private static void _savePosition()
        {
            _currentCursorPosition.X = Console.CursorLeft;
            _currentCursorPosition.Y = Console.CursorTop;
        }

        #endregion Private Methods
    }
}