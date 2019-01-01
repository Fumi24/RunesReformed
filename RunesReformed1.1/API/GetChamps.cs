using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RunesReformed1._1.RunesReformed;
using RunesReformed1.Models;

namespace RunesReformed1._1.API
{
    public class GetChamps
    {
        public List<Champion> GetChampions()
        {
            List<Champion> Champnames = new List<Champion>();
            var client = new RestClient("http://localhost:5000/api/champions");
            var request = new RestRequest();
            var restResponse = client.Execute(request);

            List<Champion> c = JsonConvert.DeserializeObject<List<Champion>>(restResponse.Content);

            foreach (var item in c)
            {
                Champnames.Add(item);
            }
            Champnames.Sort((x, y) => x.Champname.CompareTo(y.Champname));
            return Champnames;
        }
    }
}
