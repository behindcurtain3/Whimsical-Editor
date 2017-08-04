using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whimsical_Editor.Data
{
    public class Character
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("surname")]
        public string Surname { get; set; }

        [JsonProperty("culture")]
        public int Culture { get; set; }

        [JsonProperty("religion")]
        public int Religion { get; set; }

        [JsonProperty("cash")]
        public float Cash { get; set; }

        [JsonProperty("prestige")]
        public float Prestige { get; set; }

        [JsonProperty("piety")]
        public float Piety { get; set; }

        [JsonProperty("power_projection")]
        public float PowerProjection { get; set; }

        [JsonProperty("legitimacy")]
        public float Legitimacy { get; set; }

        [JsonProperty("held_titles")]
        public List<int> HeldTitles { get; set; }

        [JsonProperty("strong_claims")]
        public List<int> StrongClaims { get; set; }

        [JsonProperty("weak_claims")]
        public List<int> WeakClaims { get; set; }

        [JsonProperty("spouse")]
        public int Spouse { get; set; }

        [JsonProperty("mother")]
        public int Mother { get; set; }

        [JsonProperty("father")]
        public int Father { get; set; }

        [JsonProperty("children")]
        public List<int> Children { get; set; }

        [JsonProperty("siblings")]
        public List<int> Siblings { get; set; }

        [JsonProperty("rivals")]
        public List<int> Rivals { get; set; }

        [JsonProperty("friends")]
        public List<int> Friends { get; set; }

        [JsonProperty("lovers")]
        public List<int> Lovers { get; set; }

        [JsonProperty("id")]
        public List<int> Concubines { get; set; }

        [JsonProperty("slaves")]
        public List<int> Slaves { get; set; }

        [JsonProperty("heir")]
        public int Heir { get; set; }

        [JsonProperty("liege")]
        public int Leige { get; set; }

        [JsonProperty("regent")]
        public int Regent { get; set; }

        [JsonProperty("vassals")]
        public List<int> Vassals { get; set; }

        public Character()
        {
            HeldTitles = new List<int>();
            StrongClaims = new List<int>();
            WeakClaims = new List<int>();
            Children = new List<int>();
            Siblings = new List<int>();
            Rivals = new List<int>();
            Friends = new List<int>();
            Lovers = new List<int>();
            Concubines = new List<int>();
            Slaves = new List<int>();
            Vassals = new List<int>();
        }

        public override string ToString()
        {
            return Name + " " + Surname;
        }
    }
}
