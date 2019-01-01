using Newtonsoft.Json;
using RestSharp;
using RunesReformed1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunesReformed1._1.API
{
    public class GetPages
    {
        public List<Pages> GetRunePages()
        {
            List<Pages> pageList = new List<Pages>();
            var client = new RestClient("https://localhost:44388/api/runes");
            var request = new RestRequest();
            var restResponse = client.Execute(request);

            List<Pages> p = JsonConvert.DeserializeObject<List<Pages>>(restResponse.Content);

            foreach (var item in p)
            {
                pageList.Add(item);
            }
            return pageList;
        }
    }
}
