/*
Module Name:  LoggerCommand.cs
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
    using SManager.Core.CommandFactory;
    using System;

    /// <summary>
    /// The logger command.
    /// </summary>
    public class LoggerCommand : ICommand
    {
        /// <summary>
        /// Defines the name.
        /// </summary>
        private string name;

        /// <summary>
        /// Defines the isPrimed.
        /// </summary>
        private bool isPrimed;

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <returns>A string.</returns>
        public string GetName()
        {
            return name;
        }

        /// <summary>
        /// Sets the name.
        /// </summary>
        /// <param name="value">The value.</param>
        public void SetName(string value)
        {
            if (value != name)
            {
                isPrimed = true;
                name = value;
            }
            else
            {
                isPrimed = false;
                name = String.Empty;
            }
        }

        /// <summary>
        /// Gets a value indicating whether is primed..
        /// </summary>
        public bool IsPrimed { get => isPrimed; }

        /// <summary>
        /// Executes the.
        /// </summary>
        public void Execute(object data)
        {
            SManager.Core.Program core = new Program();
            if (!IsPrimed)
            {
                Console.WriteLine($"The LoggerCommand is NOT primed!!");
            }
            else
            {
                Logger.DoLog($"\"{GetName()}\" ({DateTime.Now}): {data}");
            }
        }

        /// <summary>
        /// Executes the.
        /// </summary>
        public void Execute()
        {
            SManager.Core.Program core = new Program();
            if (!IsPrimed)
            {
                Console.WriteLine($"The LoggerCommand is NOT primed!!");
            }
            else
            {
                Logger.DoLog($"\"{GetName()}\" ({DateTime.Now}): {core.SettingsJson}");
            }
        }
    }
}