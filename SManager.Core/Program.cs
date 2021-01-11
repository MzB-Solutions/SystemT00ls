/*
Module Name:  Program.cs
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

namespace SManager.Core
{
    using SManager.Core.CommandFactory;

    /// <summary>
    /// The command source.
    /// </summary>
    public enum CommandSource
    {
        /// <summary>
        /// Defines the logger.
        /// </summary>
        logger,

        /// <summary>
        /// Defines the modules.
        /// </summary>
        modules
    }

    /// <summary>
    /// The program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the settings.
        /// </summary>
        private Settings settings;

        /// <summary>
        /// Gets or sets the Settings.
        /// </summary>
        public Settings Settings { get => settings; set => settings = value; }

        /// <summary>
        /// Bootstraps the command.
        /// </summary>
        /// <param name="cmdSource">The cmd source.</param>
        /// <param name="owner">The owner.</param>
        /// <returns>An ICommand.</returns>
        public static ICommand BootstrapCommand(CommandSource cmdSource, string owner)
        {
            ICommand cmd = new Factory().GetCommand(cmdSource);
            cmd.SetName(owner);
            return cmd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Program" /> class.
        /// </summary>
        public Program()
        {
            Settings = new Settings();
        }
    }
}