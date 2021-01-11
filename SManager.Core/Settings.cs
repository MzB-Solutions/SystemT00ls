/*
Module Name:  Settings.cs
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
    using System.Collections.Generic;
    using System.Text.Json;

    /// <summary>
    /// The settings.
    /// </summary>
    public class Settings
    {
        internal Core.CommandFactory.ICommand logger = Core.Program.BootstrapCommand(Core.CommandSource.logger, "SManager.Core.Settings");

        /// <summary>
        /// The config set.
        /// </summary>
        internal struct ConfigSet
        {
            /// <summary>
            /// Defines the id.
            /// </summary>
            public int id;

            /// <summary>
            /// Defines the name.
            /// </summary>
            public string name;

            /// <summary>
            /// Defines the value.
            /// </summary>
            public object value;
        }

        /// <summary>
        /// Defines the fullConfig.
        /// </summary>
        private List<ConfigSet> fullConfig;

        /// <summary>
        /// Gets or sets the full config..
        /// </summary>
        internal List<ConfigSet> FullConfig { get => fullConfig; set => fullConfig = value; }

        /// <summary>
        /// adds the config.
        /// </summary>
        private void AddConfig()
        {
            ConfigSet config1 = new ConfigSet
            {
                id = 0,
                name = "AppName",
                value = "SManager"
            };
            ConfigSet config2 = new ConfigSet
            {
                id = 1,
                name = "MakeService",
                value = false
            };
            fullConfig.Add(config1);
            fullConfig.Add(config2);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Settings" /> class.
        /// </summary>
        public Settings()
        {
            AddConfig();

            if (checkdump())
            {
                logger.Execute("This is a message for testing");
            }
            else
            {
                logger.Execute("This is a message for testing too");
            }
        }

        /// <summary>
        /// checkdumps the.
        /// </summary>
        /// <returns>A bool.</returns>
        private bool checkdump()
        {
            var jsonData = DUMP();
            var configData = JsonSerializer.Deserialize<List<ConfigSet>>(jsonData);
            return configData == FullConfig;
        }

        /// <summary>
        /// Do a quick and dirty json dump
        /// </summary>
        /// <returns>A sanitized json string of <see cref="FullConfig" />.</returns>
        public string DUMP() => JsonSerializer.Serialize(FullConfig);
    }
}