using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Whimsical_Editor.Data;

namespace Whimsical_Editor.Wrappers
{
    public class RealmJsonFile
    {
        [JsonProperty("realms")]
        public List<Realm> Realms { get; set; }

        [JsonIgnore]
        public string FileName { get; set; }
        
        public RealmJsonFile()
        {
            Realms = new List<Realm>();
        }
    }
}
