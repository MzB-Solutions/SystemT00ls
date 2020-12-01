using EasyConsole;
using System;
using System.Threading;
using SManager.CoreLib;
using static SManager.Cli.OurCursor;

namespace SManager.Cli
{
    /// <summary>
    /// This generates a notice (upon construction) the displays 2 lines from the bottom
    /// </summary>
    internal class Notice
    {
        #region Private Fields

        /// <summary>
        /// a struct of 2 ints for X and Y position of the (current) cursor
        /// </summary>
        private static Position _currentCursorPosition;

        /// <summary>
        /// a struct of 2 ints for X and Y positions of the temp/notice cursor
        /// </summary>
        private static Position _tempCursorPosition;

        /// <summary>
        /// the initial X offset of the notice-cursor
        /// </summary>
        /// <remarks>DEFAULT: -5</remarks>
        private readonly int _offsetX = -5;

        /// <summary>
        /// the initial Y offset for the notice-cursor
        /// </summary>
        /// <remarks>DEFAULT: -2</remarks>
        private readonly int _offsetY = -2;

        #endregion Private Fields

        #region Private Methods

        private static void _noticePosition()
        {
            Console.SetCursorPosition(_tempCursorPosition.X, _tempCursorPosition.Y);
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

        #region Public Constructors

        /// <summary>
        /// Display a notice, somewhere near the bottom in red
        /// </summary>
        /// <param name="_noticeText">A string containing the message to display</param>
        /// <param name="_cleanMe">
        /// Are we cleaning up after ourselves (true) or do we put a message at the bottom and leave
        /// it there (false)?
        /// </param>
        /// <param name="color">
        /// This is actually an enum <seealso cref="NoticeType" /> of <see cref="ConsoleColor" /> s.
        /// </param>
        /// <param name="_length">The length of time (in seconds) to wait, to reset the cursor</param>
        /// <param name="_bgcolor">This is normally black, but can be changed at will to any <see cref="ConsoleColor" /></param>
        public Notice(string _noticeText, bool _cleanMe, NoticeType color, int _length = 1, ConsoleColor _bgcolor = ConsoleColor.Black)
        {
            // save our cursor position, before we touch it.
            _savePosition();
            string _prefix = color switch
            {
                NoticeType.Info => "Information: ",
                NoticeType.Warning => "Warning: ",
                NoticeType.Error => "ERROR: ",
                NoticeType.Message => "Notice: ",
                _ => "",
            };
            _offsetX -= _prefix.Length;
            _tempCursorPosition.X = Console.WindowWidth
                        - _noticeText.Length
                        + _offsetX;
            _tempCursorPosition.Y = Console.WindowHeight
                                    + _offsetY;
            // set our cursor to the fully calculated X/Y offsets
            _noticePosition();
            if (_bgcolor != ConsoleColor.Black)
            {
                Output.WriteLine((ConsoleColor)color, _bgcolor, "{0}{1}", _prefix, _noticeText);
            }
            else
            {
                // We're simply casting straight to a Console-color, since our enum is made of them
                // anyways. (twice) I cannot see this going wrong :P
                // TODO: might need to try-catch this a bit neater
                Output.WriteLine((ConsoleColor)color, "{0}{1}", _prefix, _noticeText);
            }
            // reset our position to the start of the message (makes it look neater)
            _noticePosition();
            // if true, we're just a temporary message for _length seconds
            if (_cleanMe)
            {
                // just making sure we're not passing in 0 as a value since then, there aint no
                // message lulz
                _length = IntTools.Clamp(_length, 1, 30);
                // then sleep for _length seconds
                Thread.Sleep(TimeSpan.FromSeconds(_length));
                // again,reset our position to the start of the message
                _noticePosition();
                // and overwrite the current notice in background color
                Output.WriteLine(_bgcolor, "{0}{1}", _prefix, _noticeText);
            }
            // now go back to the original cursor position
            _restorePosition();
        }

        #endregion Public Constructors

        #region Public Enums

        /// <summary>
        /// A simple list of colours by severity of message-type
        /// </summary>
        /// <remarks>
        /// Info = White <br /> Warning = Yellow <br /> Message = Green <br /> Error = Red <br />
        /// </remarks>
        public enum NoticeType
        {
            Info = ConsoleColor.White,
            Warning = ConsoleColor.Yellow,
            Error = ConsoleColor.Red,
            Message = ConsoleColor.Green
        }

        #endregion Public Enums
    }
}