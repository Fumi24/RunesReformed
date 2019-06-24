using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Extern
{
    public class Champion
    {
        public int ID;
        public string Champname;
        public Champion(int i, string s)
        {
            ID = i;
            Champname = s;
        }
/*

        public override string ToString()
        {
            return $"\"ID\":{ID},\"Champname\":\"{Champname}\"";
        }*/
    }
}
