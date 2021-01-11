/*
Module Name:  Factory.cs
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

namespace SManager.Core.CommandFactory
{
    using SManager.Core.Logger;

    /// <summary>
    /// The factory.
    /// </summary>
    public class Factory
    {
        /// <summary>
        /// Gets the command.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>An ICommand.</returns>
        public ICommand GetCommand(CommandSource source)
        {
            return source switch
            {
                CommandSource.logger => new LoggerCommand(),
                CommandSource.modules => null,
                _ => null,
            };
        }
    }
}