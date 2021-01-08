using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SManager.Core
{
    public class Settings
    {
        public struct ConfigSet
        {
            public int id;
            public string name;
            public object value;
        }

        private List<ConfigSet> fullConfig = new List<ConfigSet> { };

        public List<ConfigSet> FullConfig { get => fullConfig; set => fullConfig = value; }

        private void addConfig()
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

        public Settings()
        {
            addConfig();
        }

        public string DUMP(object data) => JsonConvert.SerializeObject(data);
    }
}