using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Whimsical_Editor.Data;

namespace Whimsical_Editor.Wrappers
{
    public class ProvinceJsonFile
    {
        [JsonProperty("provinces")]
        public List<Province> Provinces { get; set; }

        [JsonIgnore]
        public string FileName { get; set; }

        public ProvinceJsonFile()
        {
            Provinces = new List<Province>();
        }
    }
}
