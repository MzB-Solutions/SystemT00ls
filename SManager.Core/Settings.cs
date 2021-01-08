using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SManager.Core
{
    /// <summary>
    /// The settings.
    /// </summary>
    public class Settings
    {
        /// <summary>
        /// The config set.
        /// </summary>
        internal struct ConfigSet
        {
            public int id;
            public string name;
            public object value;
        }

        private List<ConfigSet> fullConfig;

        /// <summary>
        /// Gets or sets the full config.
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
            FullConfig.Add(config1);
            FullConfig.Add(config2);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Settings"/> class.
        /// </summary>
        public Settings()
        {
            AddConfig();
        }

        /// <summary>
        /// DS the u m p.
        /// </summary>
        /// <returns>A string.</returns>
        public string DUMP() => JsonConvert.SerializeObject(FullConfig);
    }
}