using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Whimsical_Editor.Wrappers;

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

        [JsonIgnore]
        public GameData Data { get; set; }

        [JsonIgnore]
        public string FileName { get; set; }

        public Mod()
        {
            ProvinceFiles = new List<string>();
            LocalizationFiles = new List<string>();
            RealmFiles = new List<string>();
            Data = new GameData();
        }
    }

    public class GameData
    {
        public List<Province> Provinces { get; set; }
        public List<RealmJsonFile> RealmFiles { get; set; }

        public GameData()
        {
            Provinces = new List<Province>();
            RealmFiles = new List<RealmJsonFile>();
        }
    }
}
