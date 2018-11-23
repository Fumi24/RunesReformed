using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunesReformed1.Models
{
    public class Pages
    {
        [JsonProperty("_pageName")]
        public string PageName { get; set; }

        [JsonProperty("_runeStart")]
        public long RuneStart { get; set; }

        [JsonProperty("_rune1")]
        public long Rune1 { get; set; }

        [JsonProperty("_rune2")]
        public long Rune2 { get; set; }

        [JsonProperty("_rune3")]
        public long Rune3 { get; set; }

        [JsonProperty("_rune4")]
        public long Rune4 { get; set; }

        [JsonProperty("_runeSecondary")]
        public long RuneSecondary { get; set; }

        [JsonProperty("_rune5")]
        public long Rune5 { get; set; }

        [JsonProperty("_rune6")]
        public long Rune6 { get; set; }

        [JsonProperty("_rune7")]
        public long Rune7 { get; set; }

        [JsonProperty("_rune8")]
        public long Rune8 { get; set; }

        [JsonProperty("_rune9")]
        public long Rune9 { get; set; }

        [JsonProperty("_ID")]
        public long Id { get; set; }
    }
}
