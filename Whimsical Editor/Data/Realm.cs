using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Whimsical_Editor.Data
{
    public class Realm : Notifier
    {
        #region Fields

        private int _id;
        private string _name;

        #endregion

        [JsonProperty("id")]
        public int ID
        {
            get { return _id; }
            set
            {
                _id = value;
                Notify("ID");
            }
        }

        [JsonProperty("name")]
        public String Name
        {
            get { return _name; }
            set
            {
                _name = value;
                Notify("Name");
            }
        }

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

        [JsonIgnore]
        public TreeNode Node { get; set; }

        public Realm()
        {
            Provinces = new List<int>();
            ProvincesDeJure = new List<int>();
            Vassals = new List<int>();
            VassalsDeJure = new List<int>();
        }

        public override string ToString()
        {
            return ID.ToString() + " - " + Name;
        }
    }
}
