/*
Module Name:  Logger.cs
Project:             <Sample Name>
Author:	           HOME\smzb
Copyright (c) 2000-2021 MzB Solutions

<Description of the file>

This source is subject to the Unlicense.
See https://github.com/MzB-Solutions/SManager/raw/master/LICENSE.
All other rights reserved.

THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND,
EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED
WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
*/

namespace SManager.Core.Logger
{
    using System;

    /// <summary>
    /// The logger.
    /// </summary>
    public class Logger
    {
        /// <summary>
        /// Dos the log.
        /// </summary>
        /// <param name="message">The message.</param>
        public static void DoLog(string message)
        {
            Console.WriteLine($"The following message was logged: {message}");
        }
    }
}