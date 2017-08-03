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
        
        [JsonIgnore]
        public GameData Data { get; set; }

        [JsonIgnore]
        public string FileName { get; set; }

        public Mod()
        {
            Data = new GameData();
        }
    }

    public class GameData
    {
        public List<ProvinceJsonFile> ProvinceFiles { get; set; }
        public List<RealmJsonFile> RealmFiles { get; set; }

        public GameData()
        {
            ProvinceFiles = new List<ProvinceJsonFile>();
            RealmFiles = new List<RealmJsonFile>();
        }
    }
}
