using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Extern;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

namespace API.Controllers
{

    public class Id
    {
        public int championId { get; set; }
        public string role { get; set; }
    }

    public class HighestCount
    {
        public int count { get; set; }
        public int wins { get; set; }
        public double winrate { get; set; }
        public string hash { get; set; }
    }

    public class HighestWinrate
    {
        public int count { get; set; }
        public int wins { get; set; }
        public double winrate { get; set; }
        public string hash { get; set; }
    }

    public class Finalitemshashfixed
    {
        public HighestCount highestCount { get; set; }
        public HighestWinrate highestWinrate { get; set; }
    }

    public class HighestCount2
    {
        public int count { get; set; }
        public int wins { get; set; }
        public double winrate { get; set; }
        public string hash { get; set; }
    }

    public class HighestWinrate2
    {
        public int count { get; set; }
        public int wins { get; set; }
        public double winrate { get; set; }
        public string hash { get; set; }
    }

    public class Masterieshash
    {
        public HighestCount2 highestCount { get; set; }
        public HighestWinrate2 highestWinrate { get; set; }
    }

    public class HighestCount3
    {
        public int count { get; set; }
        public int wins { get; set; }
        public double winrate { get; set; }
        public string hash { get; set; }
    }

    public class HighestWinrate3
    {
        public int count { get; set; }
        public int wins { get; set; }
        public double winrate { get; set; }
        public string hash { get; set; }
    }

    public class Skillorderhash
    {
        public HighestCount3 highestCount { get; set; }
        public HighestWinrate3 highestWinrate { get; set; }
    }

    public class HighestCount4
    {
        public int count { get; set; }
        public int wins { get; set; }
        public double winrate { get; set; }
        public string hash { get; set; }
    }

    public class HighestWinrate4
    {
        public int count { get; set; }
        public int wins { get; set; }
        public double winrate { get; set; }
        public string hash { get; set; }
    }

    public class Summonershash
    {
        public HighestCount4 highestCount { get; set; }
        public HighestWinrate4 highestWinrate { get; set; }
    }

    public class HighestCount5
    {
        public int count { get; set; }
        public int wins { get; set; }
        public double winrate { get; set; }
        public string hash { get; set; }
    }

    public class HighestWinrate5
    {
        public int count { get; set; }
        public int wins { get; set; }
        public double winrate { get; set; }
        public string hash { get; set; }
    }

    public class Trinkethash
    {
        public HighestCount5 highestCount { get; set; }
        public HighestWinrate5 highestWinrate { get; set; }
    }

    public class HighestCount6
    {
        public int count { get; set; }
        public int wins { get; set; }
        public double winrate { get; set; }
        public string hash { get; set; }
    }

    public class HighestWinrate6
    {
        public int count { get; set; }
        public int wins { get; set; }
        public double winrate { get; set; }
        public string hash { get; set; }
    }

    public class Firstitemshash
    {
        public HighestCount6 highestCount { get; set; }
        public HighestWinrate6 highestWinrate { get; set; }
    }

    public class HighestCount7
    {
        public int count { get; set; }
        public int wins { get; set; }
        public double winrate { get; set; }
        public string hash { get; set; }
    }

    public class HighestWinrate7
    {
        public int count { get; set; }
        public int wins { get; set; }
        public double winrate { get; set; }
        public string hash { get; set; }
    }

    public class Runehash
    {
        public HighestCount7 highestCount { get; set; }
        public HighestWinrate7 highestWinrate { get; set; }
    }

    public class Hashes
    {
        public Finalitemshashfixed finalitemshashfixed { get; set; }
        public Masterieshash masterieshash { get; set; }
        public Skillorderhash skillorderhash { get; set; }
        public Summonershash summonershash { get; set; }
        public Trinkethash trinkethash { get; set; }
        public Firstitemshash firstitemshash { get; set; }
        public Runehash runehash { get; set; }
    }

    public class RootObject
    {
        public Id _id { get; set; }
        public string elo { get; set; }
        public string patch { get; set; }
        public int championId { get; set; }
        public double winRate { get; set; }
        public double playRate { get; set; }
        public int gamesPlayed { get; set; }
        public double percentRolePlayed { get; set; }
        public double banRate { get; set; }
        public string role { get; set; }
        public Hashes hashes { get; set; }
    }

    public class RunePage
    {
        //Mid 54%HC
        private bool HW;
        private double Percent;
        private string Role;

        public string _pageName;
        public string _runeStart, _rune1, _rune2, _rune3, _rune4, _runeSecondary, _rune5, _rune6,_ID, _rune7, _rune8, _rune9;
        public RunePage(string role, double percentage, bool hw, string hash, string id)
        {
            HW = hw;
            Percent = percentage;

            if (string.IsNullOrWhiteSpace(role)) throw new ArgumentNullException(nameof(role));

            if (role == "JUNGLE")
                Role = "Jungle";
            else if (role == "DUO_SUPPORT")
                Role = "Support";
            else if (role == "DUO_CARRY")
                Role = "ADC";
            else if (role == "MIDDLE")
                Role = "Mid";
            else if (role == "TOP")
                Role = "Top";

            _ID = id;
            _pageName = $"{Role} {Percent}%{(HW ? "HW" : "HC")}";

            if (string.IsNullOrWhiteSpace(hash)) throw new ArgumentNullException(nameof(hash));
            var hashSplitted = hash.Split('-');
            if (hashSplitted.Length < 11) throw new ArgumentOutOfRangeException(nameof(hashSplitted));
            _runeStart = hashSplitted[0];
            _rune1 = hashSplitted[1];
            _rune2 = hashSplitted[2];
            _rune3 = hashSplitted[3];
            _rune4 = hashSplitted[4];
            _runeSecondary = hashSplitted[5];
            _rune5 = hashSplitted[6];
            _rune6 = hashSplitted[7];
            _rune7 = hashSplitted[8];
            _rune8 = hashSplitted[9];
            _rune9 = hashSplitted[10];



        }

        public string GetPageName()
        {
            return @"""_pageNamee:""" + $@"{Role} {Percent}%{(HW ? "HW" : "HC")}""";
        }

        public string GetRunes()
        {
            return
                $@"""_runeStart"":{_runeStart},""_rune1"":{_rune1},""_rune2"":{_rune2},""_rune3"":{_rune3},""_rune4"":{_rune4},""_runeSecondary"":{_runeSecondary},""_rune5"":{_rune5},""_rune6"":{_rune6},""_rune7"":{_rune7},""_rune8"":{_rune8},""_rune9"":{_rune9}";

        }

        public override string ToString()
        {
            return GetPageName() + "," + GetRunes();
        }
    }


    [Route("api/[controller]")]
    [ApiController]
    public class RunesController : ControllerBase
    {
        
        // GET: api/Runes
        [HttpGet]
        public RunePage[] Get()
        {
            return Startup.cachedPages;
        }

        // GET: api/Runes/5
        [HttpGet("{id}", Name = "Gett")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Runes
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Runes/5
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
