using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using API.Controllers;
using API.Extern;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using RestSharp;

namespace API
{
    public class Startup
    {

        public static RunePage[] cachedPages = null;

        public static DateTime lastRefresh = DateTime.Now;

        private Timer workTimer;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            
            workTimer = new Timer(Work, null, 0, 1000 * 60 * 60 * 4); // every 4 hours it refreshes without queries
        }

        public static readonly string API_KEY = "<KEY_HERE>";

        private void Work(object state)
        {
            Console.WriteLine("API refresh start");
            if (Startup.cachedPages != null)
            {
                var diff = (DateTime.Now - Startup.lastRefresh).TotalMinutes;
                if (diff < 60)
                    return;
                else
                    Startup.lastRefresh = DateTime.Now; // and continue = refresh
            }

            List<RunePage> pages = new List<RunePage>();

            
            foreach (var champion in Champions.ChampionsList)
            {
                var client = new RestClient("http://api.champion.gg");
                var request = new RestRequest($"v2/champions/{champion.ID}?elo=PLATINUM&limit=200&champData=hashes&api_key={API_KEY}", Method.GET);

                var queryResult = client.Execute<List<RootObject>>(request).Data;

                foreach (var rootObject in queryResult)
                {
                    if (rootObject.hashes.runehash == null) // once missing hash
                    {
                        Console.WriteLine($"Champion {champion.ID} is missing data");
                    }
                    else
                    {
                        Console.WriteLine("Added " + champion.Champname);
                        pages.Add(new RunePage(rootObject.role, (int)(rootObject.hashes.runehash.highestWinrate.winrate * 100), true, rootObject.hashes.runehash.highestWinrate.hash, rootObject._id.championId.ToString()));
                        pages.Add(new RunePage(rootObject.role, (int)(rootObject.hashes.runehash.highestCount.winrate * 100), false, rootObject.hashes.runehash.highestCount.hash, rootObject._id.championId.ToString()));
                    }
                }
            }

            Startup.cachedPages = pages.ToArray();
            Console.WriteLine("API refresh end");
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
