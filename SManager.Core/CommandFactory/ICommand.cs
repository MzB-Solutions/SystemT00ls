/*
Module Name:  ICommand.cs
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
    /// <summary>
    /// The i command.
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <returns>A string.</returns>
        string GetName();

        /// <summary>
        /// Sets the name.
        /// </summary>
        /// <param name="value">The value.</param>
        void SetName(string value);

        /// <summary>
        /// Gets the IsPrimed Gets a value indicating whether is primed..
        /// </summary>
        bool IsPrimed { get; }

        /// <summary>
        /// Executes the.
        /// </summary>
        void Execute();

        /// <summary>
        /// Executes the.
        /// </summary>
        /// <param name="data">The data.</param>
        void Execute(object data);
    }
}