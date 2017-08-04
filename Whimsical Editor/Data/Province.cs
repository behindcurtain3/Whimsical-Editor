using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Whimsical_Editor.Data
{
    public class Province
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("name")]
        public String Name { get; set; }

        [JsonProperty("terrain_type")]
        public String Terrain { get; set; }

        [JsonProperty("prosperity")]
        public float Prosperity { get; set; }

        [JsonProperty("R")]
        public byte R { get; set; }

        [JsonProperty("G")]
        public byte G { get; set; }

        [JsonProperty("B")]
        public byte B { get; set; }

        [JsonProperty("adjacencies")]
        public List<int> Adjacencies { get; set; }

        [JsonIgnore]
        public TreeNode Node { get; set; }

        public Province()
        {
            Adjacencies = new List<int>();
        }

        public override string ToString()
        {
            return ID.ToString() + " - " + Name;
        }
    }
}
