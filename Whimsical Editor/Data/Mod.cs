using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whimsical_Editor.Data
{
    public class Mod
    {
        [JsonProperty("id")]
        public String ID { get; set; }

        [JsonProperty("name")]
        public String Name { get; set; }

        [JsonProperty("author")]
        public String Author { get; set; }

        [JsonProperty("description")]
        public String Description { get; set; }

        [JsonProperty("provinces_to_add")]
        public List<string> ProvinceFiles { get; set; }

        [JsonProperty("localizations_to_add")]
        public List<string> LocalizationFiles { get; set; }

        [JsonProperty("realms_to_add")]
        public List<string> RealmFiles { get; set; }

        public Mod()
        {
            ProvinceFiles = new List<string>();
            LocalizationFiles = new List<string>();
            RealmFiles = new List<string>();
        }
    }
}
