using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whimsical_Editor.Data
{
    public class Realm
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("name")]
        public String Name { get; set; }

        [JsonProperty("rank")]
        public String Rank { get; set; }

        [JsonProperty("R")]
        public byte R { get; set; }

        [JsonProperty("G")]
        public byte G { get; set; }

        [JsonProperty("B")]
        public byte B { get; set; }

        [JsonProperty("provinces")]
        public List<int> Provinces { get; set; }

        [JsonProperty("provinces_de_jure")]
        public List<int> ProvincesDeJure { get; set; }

        [JsonProperty("vassals")]
        public List<int> Vassals { get; set; }

        [JsonProperty("vassals_de_jure")]
        public List<int> VassalsDeJure { get; set; }

        public Realm()
        {
            Provinces = new List<int>();
            ProvincesDeJure = new List<int>();
            Vassals = new List<int>();
            VassalsDeJure = new List<int>();
        }
    }
}
