using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RunesReformed1.Models
{
    public class Champion
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("champname")]
        public string Champname { get; set; }
    }
}
