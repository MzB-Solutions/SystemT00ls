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

namespace SManager.Cli
{
    using System;

    /// <summary>
    /// Defines the <see cref="Program" />.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The Main.
        /// </summary>
        /// <param name="_args">The _args <see cref="string[]" />.</param>
        private static void Main(string[] _args)
        {
            Console.WriteLine("Hello World!");
            if (_args.Length <= 1) { }
            else
            {
            }
            var cmdLogger = Core.Program.BootstrapCommand(Core.CommandSource.logger, "SManager.Cli");
            if (cmdLogger.IsPrimed)
            {
                cmdLogger.Execute();
            }
            else
            {
                Console.WriteLine("The logger wasnt primed correctly");
            }

            _ = Console.ReadKey();
        }
    }
}