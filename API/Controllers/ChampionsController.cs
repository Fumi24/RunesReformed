using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Extern;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChampionsController : ControllerBase
    {
        // GET: api/Champion
        [HttpGet]
        public Champion[] Get()
        {
            return Champions.ChampionsList.ToArray();
        }

        // GET: api/Champion/555
        [HttpGet("{id}", Name = "Get")]
        public string Get(string x)
        {
            return "";
        }
        
        // POST: api/Champion
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Champion/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
