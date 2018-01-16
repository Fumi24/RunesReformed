using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunesReformed1._1.Translators
{
    public class RiotTranslator
    {
        public int[] Translate(string riotURL)
        {
            string[] result = riotURL.Split('=');

            string fullbuild = result[1];

            int[] BuildArray = fullbuild.ToString().Select(o => Convert.ToInt32(o)).ToArray();

            for (int i = 0; i < BuildArray.Length; i++)
            {
                BuildArray[i] = BuildArray[i] - 48;
            }


            if (BuildArray[0] == 0)
            {
                BuildArray[0] = 8000;
                if (BuildArray[1] == 0)
                {
                    BuildArray[1] = 8005;
                }
                if (BuildArray[1] == 1)
                {
                    BuildArray[1] = 8008;
                }
                if (BuildArray[1] == 2)
                {
                    BuildArray[1] = 8021;
                }
                if (BuildArray[2] == 0)
                {
                    BuildArray[2] = 9101;
                }
                if (BuildArray[2] == 1)
                {
                    BuildArray[2] = 9111;
                }
                if (BuildArray[2] == 2)
                {
                    BuildArray[2] = 8009;
                }
                if (BuildArray[3] == 0)
                {
                    BuildArray[3] = 9104;
                }
                if (BuildArray[3] == 1)
                {
                    BuildArray[3] = 9105;
                }
                if (BuildArray[3] == 2)
                {
                    BuildArray[3] = 9103;
                }
                if (BuildArray[4] == 0)
                {
                    BuildArray[4] = 8014;
                }
                if (BuildArray[4] == 1)
                {
                    BuildArray[4] = 8017;
                }
                if (BuildArray[4] == 2)
                {
                    BuildArray[4] = 8299;
                }
                if (BuildArray[5] == 0 && BuildArray[0] == 8000)
                {
                    BuildArray[5] = 8100;
                    if (BuildArray[6] == 0)
                    {
                        BuildArray[6] = 8126;
                    }
                    if (BuildArray[7] == 0)
                    {
                        BuildArray[7] = 8126;
                    }
                    if (BuildArray[6] == 1)
                    {
                        BuildArray[6] = 8139;
                    }
                    if (BuildArray[7] == 1)
                    {
                        BuildArray[7] = 8139;
                    }
                    if (BuildArray[6] == 2)
                    {
                        BuildArray[6] = 8143;
                    }
                    if (BuildArray[7] == 2)
                    {
                        BuildArray[7] = 8143;
                    }
                    if (BuildArray[6] == 3)
                    {
                        BuildArray[6] = 8136;
                    }
                    if (BuildArray[7] == 3)
                    {
                        BuildArray[7] = 8136;
                    }
                    if (BuildArray[6] == 4)
                    {
                        BuildArray[6] = 8120;
                    }
                    if (BuildArray[7] == 4)
                    {
                        BuildArray[7] = 8120;
                    }
                    if (BuildArray[6] == 5)
                    {
                        BuildArray[6] = 8138;
                    }
                    if (BuildArray[7] == 5)
                    {
                        BuildArray[7] = 8138;
                    }
                    if (BuildArray[6] == 6)
                    {
                        BuildArray[6] = 8135;
                    }
                    if (BuildArray[7] == 6)
                    {
                        BuildArray[7] = 8135;
                    }
                    if (BuildArray[6] == 7)
                    {
                        BuildArray[6] = 8134;
                    }
                    if (BuildArray[7] == 7)
                    {
                        BuildArray[7] = 8134;
                    }
                    if (BuildArray[6] == 8)
                    {
                        BuildArray[6] = 8105;
                    }
                    if (BuildArray[7] == 8)
                    {
                        BuildArray[7] = 8105;
                    }
                }
                if (BuildArray[5] == 1 && BuildArray[0] == 8000)
                {
                    BuildArray[5] = 8200;
                    if (BuildArray[6] == 0)
                    {
                        BuildArray[6] = 8224;
                    }
                    if (BuildArray[7] == 0)
                    {
                        BuildArray[7] = 8224;
                    }
                    if (BuildArray[6] == 1)
                    {
                        BuildArray[6] = 8226;
                    }
                    if (BuildArray[7] == 1)
                    {
                        BuildArray[7] = 8226;
                    }
                    if (BuildArray[6] == 2)
                    {
                        BuildArray[6] = 8243;
                    }
                    if (BuildArray[7] == 2)
                    {
                        BuildArray[7] = 8243;
                    }
                    if (BuildArray[6] == 3)
                    {
                        BuildArray[6] = 8210;
                    }
                    if (BuildArray[7] == 3)
                    {
                        BuildArray[7] = 8210;
                    }
                    if (BuildArray[6] == 4)
                    {
                        BuildArray[6] = 8234;
                    }
                    if (BuildArray[7] == 4)
                    {
                        BuildArray[7] = 8234;
                    }
                    if (BuildArray[6] == 5)
                    {
                        BuildArray[6] = 8233;
                    }
                    if (BuildArray[7] == 5)
                    {
                        BuildArray[7] = 8233;
                    }
                    if (BuildArray[6] == 6)
                    {
                        BuildArray[6] = 8237;
                    }
                    if (BuildArray[7] == 6)
                    {
                        BuildArray[7] = 8237;
                    }
                    if (BuildArray[6] == 7)
                    {
                        BuildArray[6] = 8232;
                    }
                    if (BuildArray[7] == 7)
                    {
                        BuildArray[7] = 8232;
                    }
                    if (BuildArray[6] == 8)
                    {
                        BuildArray[6] = 8236;
                    }
                    if (BuildArray[7] == 8)
                    {
                        BuildArray[7] = 8236;
                    }
                }
                if (BuildArray[5] == 2 && BuildArray[0] == 8000)
                {
                    BuildArray[5] = 8400;
                    if (BuildArray[6] == 0)
                    {
                        BuildArray[6] = 8242;
                    }
                    if (BuildArray[7] == 0)
                    {
                        BuildArray[7] = 8242;
                    }
                    if (BuildArray[6] == 1)
                    {
                        BuildArray[6] = 8446;
                    }
                    if (BuildArray[7] == 1)
                    {
                        BuildArray[7] = 8446;
                    }
                    if (BuildArray[6] == 2)
                    {
                        BuildArray[6] = 8463;
                    }
                    if (BuildArray[7] == 2)
                    {
                        BuildArray[7] = 8463;
                    }
                    if (BuildArray[6] == 3)
                    {
                        BuildArray[6] = 8430;
                    }
                    if (BuildArray[7] == 3)
                    {
                        BuildArray[7] = 8430;
                    }
                    if (BuildArray[6] == 4)
                    {
                        BuildArray[6] = 8435;
                    }
                    if (BuildArray[7] == 4)
                    {
                        BuildArray[7] = 8435;
                    }
                    if (BuildArray[6] == 5)
                    {
                        BuildArray[6] = 8429;
                    }
                    if (BuildArray[7] == 5)
                    {
                        BuildArray[7] = 8429;
                    }
                    if (BuildArray[6] == 6)
                    {
                        BuildArray[6] = 8451;
                    }
                    if (BuildArray[7] == 6)
                    {
                        BuildArray[7] = 8451;
                    }
                    if (BuildArray[6] == 7)
                    {
                        BuildArray[6] = 8453;
                    }
                    if (BuildArray[7] == 7)
                    {
                        BuildArray[7] = 8453;
                    }
                    if (BuildArray[6] == 8)
                    {
                        BuildArray[6] = 8444;
                    }
                    if (BuildArray[7] == 8)
                    {
                        BuildArray[7] = 8444;
                    }
                }
                if (BuildArray[5] == 3 && BuildArray[0] == 8000)
                {
                    BuildArray[5] = 8300;
                    if (BuildArray[6] == 0)
                    {
                        BuildArray[6] = 8306;
                    }
                    if (BuildArray[7] == 0)
                    {
                        BuildArray[7] = 8306;
                    }
                    if (BuildArray[6] == 1)
                    {
                        BuildArray[6] = 8345;
                    }
                    if (BuildArray[7] == 1)
                    {
                        BuildArray[7] = 8345;
                    }
                    if (BuildArray[6] == 2)
                    {
                        BuildArray[6] = 8313;
                    }
                    if (BuildArray[7] == 2)
                    {
                        BuildArray[7] = 8313;
                    }
                    if (BuildArray[6] == 3)
                    {
                        BuildArray[6] = 8304;
                    }
                    if (BuildArray[7] == 3)
                    {
                        BuildArray[7] = 8304;
                    }
                    if (BuildArray[6] == 4)
                    {
                        BuildArray[6] = 8321;
                    }
                    if (BuildArray[7] == 4)
                    {
                        BuildArray[7] = 8321;
                    }
                    if (BuildArray[6] == 5)
                    {
                        BuildArray[6] = 8316;
                    }
                    if (BuildArray[7] == 5)
                    {
                        BuildArray[7] = 8316;
                    }
                    if (BuildArray[6] == 6)
                    {
                        BuildArray[6] = 8347;
                    }
                    if (BuildArray[7] == 6)
                    {
                        BuildArray[7] = 8347;
                    }
                    if (BuildArray[6] == 7)
                    {
                        BuildArray[6] = 8410;
                    }
                    if (BuildArray[7] == 7)
                    {
                        BuildArray[7] = 8410;
                    }
                    if (BuildArray[6] == 8)
                    {
                        BuildArray[6] = 8339;
                    }
                    if (BuildArray[7] == 8)
                    {
                        BuildArray[7] = 8339;
                    }
                }
            }


            if (BuildArray[0] == 1)
            {
                BuildArray[0] = 8100;
                if (BuildArray[1] == 0)
                {
                    BuildArray[1] = 8112;
                }
                if (BuildArray[1] == 1)
                {
                    BuildArray[1] = 8124;
                }
                if (BuildArray[1] == 2)
                {
                    BuildArray[1] = 8128;
                }
                if (BuildArray[2] == 0)
                {
                    BuildArray[2] = 8126;
                }
                if (BuildArray[2] == 1)
                {
                    BuildArray[2] = 8139;
                }
                if (BuildArray[2] == 2)
                {
                    BuildArray[2] = 8143;
                }
                if (BuildArray[3] == 0)
                {
                    BuildArray[3] = 8136;
                }
                if (BuildArray[3] == 1)
                {
                    BuildArray[3] = 8120;
                }
                if (BuildArray[3] == 2)
                {
                    BuildArray[3] = 8138;
                }
                if (BuildArray[4] == 0)
                {
                    BuildArray[4] = 8135;
                }
                if (BuildArray[4] == 1)
                {
                    BuildArray[4] = 8134;
                }
                if (BuildArray[4] == 2)
                {
                    BuildArray[4] = 8105;
                }
                if (BuildArray[5] == 0 && BuildArray[0] == 8100)
                {
                    BuildArray[5] = 8000;
                    if (BuildArray[6] == 0)
                    {
                        BuildArray[6] = 9101;
                    }
                    if (BuildArray[7] == 0)
                    {
                        BuildArray[7] = 9101;
                    }
                    if (BuildArray[6] == 1)
                    {
                        BuildArray[6] = 9111;
                    }
                    if (BuildArray[7] == 1)
                    {
                        BuildArray[7] = 9111;
                    }
                    if (BuildArray[6] == 2)
                    {
                        BuildArray[6] = 8009;
                    }
                    if (BuildArray[7] == 2)
                    {
                        BuildArray[7] = 8009;
                    }
                    if (BuildArray[6] == 3)
                    {
                        BuildArray[6] = 9104;
                    }
                    if (BuildArray[7] == 3)
                    {
                        BuildArray[7] = 9104;
                    }
                    if (BuildArray[6] == 4)
                    {
                        BuildArray[6] = 9105;
                    }
                    if (BuildArray[7] == 4)
                    {
                        BuildArray[7] = 9105;
                    }
                    if (BuildArray[6] == 5)
                    {
                        BuildArray[6] = 9103;
                    }
                    if (BuildArray[7] == 5)
                    {
                        BuildArray[7] = 9103;
                    }
                    if (BuildArray[6] == 6)
                    {
                        BuildArray[6] = 8014;
                    }
                    if (BuildArray[7] == 6)
                    {
                        BuildArray[7] = 8014;
                    }
                    if (BuildArray[6] == 7)
                    {
                        BuildArray[6] = 8017;
                    }
                    if (BuildArray[7] == 7)
                    {
                        BuildArray[7] = 8017;
                    }
                    if (BuildArray[6] == 8)
                    {
                        BuildArray[6] = 8299;
                    }
                    if (BuildArray[7] == 8)
                    {
                        BuildArray[7] = 8299;
                    }
                }
                if (BuildArray[5] == 1 && BuildArray[0] == 8100)
                {
                    BuildArray[5] = 8200;
                    if (BuildArray[6] == 0)
                    {
                        BuildArray[6] = 8224;
                    }
                    if (BuildArray[7] == 0)
                    {
                        BuildArray[7] = 8224;
                    }
                    if (BuildArray[6] == 1)
                    {
                        BuildArray[6] = 8226;
                    }
                    if (BuildArray[7] == 1)
                    {
                        BuildArray[7] = 8226;
                    }
                    if (BuildArray[6] == 2)
                    {
                        BuildArray[6] = 8243;
                    }
                    if (BuildArray[7] == 2)
                    {
                        BuildArray[7] = 8243;
                    }
                    if (BuildArray[6] == 3)
                    {
                        BuildArray[6] = 8210;
                    }
                    if (BuildArray[7] == 3)
                    {
                        BuildArray[7] = 8210;
                    }
                    if (BuildArray[6] == 4)
                    {
                        BuildArray[6] = 8234;
                    }
                    if (BuildArray[7] == 4)
                    {
                        BuildArray[7] = 8234;
                    }
                    if (BuildArray[6] == 5)
                    {
                        BuildArray[6] = 8233;
                    }
                    if (BuildArray[7] == 5)
                    {
                        BuildArray[7] = 8233;
                    }
                    if (BuildArray[6] == 6)
                    {
                        BuildArray[6] = 8237;
                    }
                    if (BuildArray[7] == 6)
                    {
                        BuildArray[7] = 8237;
                    }
                    if (BuildArray[6] == 7)
                    {
                        BuildArray[6] = 8232;
                    }
                    if (BuildArray[7] == 7)
                    {
                        BuildArray[7] = 8232;
                    }
                    if (BuildArray[6] == 8)
                    {
                        BuildArray[6] = 8236;
                    }
                    if (BuildArray[7] == 8)
                    {
                        BuildArray[7] = 8236;
                    }
                }
                if (BuildArray[5] == 2 && BuildArray[0] == 8100)
                {
                    BuildArray[5] = 8400;
                    if (BuildArray[6] == 0)
                    {
                        BuildArray[6] = 8242;
                    }
                    if (BuildArray[7] == 0)
                    {
                        BuildArray[7] = 8242;
                    }
                    if (BuildArray[6] == 1)
                    {
                        BuildArray[6] = 8446;
                    }
                    if (BuildArray[7] == 1)
                    {
                        BuildArray[7] = 8446;
                    }
                    if (BuildArray[6] == 2)
                    {
                        BuildArray[6] = 8463;
                    }
                    if (BuildArray[7] == 2)
                    {
                        BuildArray[7] = 8463;
                    }
                    if (BuildArray[6] == 3)
                    {
                        BuildArray[6] = 8430;
                    }
                    if (BuildArray[7] == 3)
                    {
                        BuildArray[7] = 8430;
                    }
                    if (BuildArray[6] == 4)
                    {
                        BuildArray[6] = 8435;
                    }
                    if (BuildArray[7] == 4)
                    {
                        BuildArray[7] = 8435;
                    }
                    if (BuildArray[6] == 5)
                    {
                        BuildArray[6] = 8429;
                    }
                    if (BuildArray[7] == 5)
                    {
                        BuildArray[7] = 8429;
                    }
                    if (BuildArray[6] == 6)
                    {
                        BuildArray[6] = 8451;
                    }
                    if (BuildArray[7] == 6)
                    {
                        BuildArray[7] = 8451;
                    }
                    if (BuildArray[6] == 7)
                    {
                        BuildArray[6] = 8453;
                    }
                    if (BuildArray[7] == 7)
                    {
                        BuildArray[7] = 8453;
                    }
                    if (BuildArray[6] == 8)
                    {
                        BuildArray[6] = 8444;
                    }
                    if (BuildArray[7] == 8)
                    {
                        BuildArray[7] = 8444;
                    }
                }
                if (BuildArray[5] == 3 && BuildArray[0] == 8100)
                {
                    BuildArray[5] = 8300;
                    if (BuildArray[6] == 0)
                    {
                        BuildArray[6] = 8306;
                    }
                    if (BuildArray[7] == 0)
                    {
                        BuildArray[7] = 8306;
                    }
                    if (BuildArray[6] == 1)
                    {
                        BuildArray[6] = 8345;
                    }
                    if (BuildArray[7] == 1)
                    {
                        BuildArray[7] = 8345;
                    }
                    if (BuildArray[6] == 2)
                    {
                        BuildArray[6] = 8313;
                    }
                    if (BuildArray[7] == 2)
                    {
                        BuildArray[7] = 8313;
                    }
                    if (BuildArray[6] == 3)
                    {
                        BuildArray[6] = 8304;
                    }
                    if (BuildArray[7] == 3)
                    {
                        BuildArray[7] = 8304;
                    }
                    if (BuildArray[6] == 4)
                    {
                        BuildArray[6] = 8321;
                    }
                    if (BuildArray[7] == 4)
                    {
                        BuildArray[7] = 8321;
                    }
                    if (BuildArray[6] == 5)
                    {
                        BuildArray[6] = 8316;
                    }
                    if (BuildArray[7] == 5)
                    {
                        BuildArray[7] = 8316;
                    }
                    if (BuildArray[6] == 6)
                    {
                        BuildArray[6] = 8347;
                    }
                    if (BuildArray[7] == 6)
                    {
                        BuildArray[7] = 8347;
                    }
                    if (BuildArray[6] == 7)
                    {
                        BuildArray[6] = 8410;
                    }
                    if (BuildArray[7] == 7)
                    {
                        BuildArray[7] = 8410;
                    }
                    if (BuildArray[6] == 8)
                    {
                        BuildArray[6] = 8339;
                    }
                    if (BuildArray[7] == 8)
                    {
                        BuildArray[7] = 8339;
                    }
                }
            }


            if (BuildArray[0] == 1)
            {
                BuildArray[0] = 8200;
                if (BuildArray[1] == 0)
                {
                    BuildArray[1] = 8112;
                }
                if (BuildArray[1] == 1)
                {
                    BuildArray[1] = 8124;
                }
                if (BuildArray[1] == 2)
                {
                    BuildArray[1] = 8128;
                }
                if (BuildArray[2] == 0)
                {
                    BuildArray[2] = 8126;
                }
                if (BuildArray[2] == 1)
                {
                    BuildArray[2] = 8139;
                }
                if (BuildArray[2] == 2)
                {
                    BuildArray[2] = 8143;
                }
                if (BuildArray[3] == 0)
                {
                    BuildArray[3] = 8136;
                }
                if (BuildArray[3] == 1)
                {
                    BuildArray[3] = 8120;
                }
                if (BuildArray[3] == 2)
                {
                    BuildArray[3] = 8138;
                }
                if (BuildArray[4] == 0)
                {
                    BuildArray[4] = 8135;
                }
                if (BuildArray[4] == 1)
                {
                    BuildArray[4] = 8134;
                }
                if (BuildArray[4] == 2)
                {
                    BuildArray[4] = 8105;
                }
                if (BuildArray[5] == 0 && BuildArray[0] == 8200)
                {
                    BuildArray[5] = 8000;
                    if (BuildArray[6] == 0)
                    {
                        BuildArray[6] = 9101;
                    }
                    if (BuildArray[7] == 0)
                    {
                        BuildArray[7] = 9101;
                    }
                    if (BuildArray[6] == 1)
                    {
                        BuildArray[6] = 9111;
                    }
                    if (BuildArray[7] == 1)
                    {
                        BuildArray[7] = 9111;
                    }
                    if (BuildArray[6] == 2)
                    {
                        BuildArray[6] = 8009;
                    }
                    if (BuildArray[7] == 2)
                    {
                        BuildArray[7] = 8009;
                    }
                    if (BuildArray[6] == 3)
                    {
                        BuildArray[6] = 9104;
                    }
                    if (BuildArray[7] == 3)
                    {
                        BuildArray[7] = 9104;
                    }
                    if (BuildArray[6] == 4)
                    {
                        BuildArray[6] = 9105;
                    }
                    if (BuildArray[7] == 4)
                    {
                        BuildArray[7] = 9105;
                    }
                    if (BuildArray[6] == 5)
                    {
                        BuildArray[6] = 9103;
                    }
                    if (BuildArray[7] == 5)
                    {
                        BuildArray[7] = 9103;
                    }
                    if (BuildArray[6] == 6)
                    {
                        BuildArray[6] = 8014;
                    }
                    if (BuildArray[7] == 6)
                    {
                        BuildArray[7] = 8014;
                    }
                    if (BuildArray[6] == 7)
                    {
                        BuildArray[6] = 8017;
                    }
                    if (BuildArray[7] == 7)
                    {
                        BuildArray[7] = 8017;
                    }
                    if (BuildArray[6] == 8)
                    {
                        BuildArray[6] = 8299;
                    }
                    if (BuildArray[7] == 8)
                    {
                        BuildArray[7] = 8299;
                    }
                }
                if (BuildArray[5] == 1 && BuildArray[0] == 8200)
                {
                    BuildArray[5] = 8100;
                    if (BuildArray[6] == 0)
                    {
                        BuildArray[6] = 8126;
                    }
                    if (BuildArray[7] == 0)
                    {
                        BuildArray[7] = 8126;
                    }
                    if (BuildArray[6] == 1)
                    {
                        BuildArray[6] = 8139;
                    }
                    if (BuildArray[7] == 1)
                    {
                        BuildArray[7] = 8139;
                    }
                    if (BuildArray[6] == 2)
                    {
                        BuildArray[6] = 8143;
                    }
                    if (BuildArray[7] == 2)
                    {
                        BuildArray[7] = 8143;
                    }
                    if (BuildArray[6] == 3)
                    {
                        BuildArray[6] = 8136;
                    }
                    if (BuildArray[7] == 3)
                    {
                        BuildArray[7] = 8136;
                    }
                    if (BuildArray[6] == 4)
                    {
                        BuildArray[6] = 8120;
                    }
                    if (BuildArray[7] == 4)
                    {
                        BuildArray[7] = 8120;
                    }
                    if (BuildArray[6] == 5)
                    {
                        BuildArray[6] = 8138;
                    }
                    if (BuildArray[7] == 5)
                    {
                        BuildArray[7] = 8138;
                    }
                    if (BuildArray[6] == 6)
                    {
                        BuildArray[6] = 8135;
                    }
                    if (BuildArray[7] == 6)
                    {
                        BuildArray[7] = 8135;
                    }
                    if (BuildArray[6] == 7)
                    {
                        BuildArray[6] = 8134;
                    }
                    if (BuildArray[7] == 7)
                    {
                        BuildArray[7] = 8134;
                    }
                    if (BuildArray[6] == 8)
                    {
                        BuildArray[6] = 8105;
                    }
                    if (BuildArray[7] == 8)
                    {
                        BuildArray[7] = 8105;
                    }
                }
                if (BuildArray[5] == 2 && BuildArray[0] == 8200)
                {
                    BuildArray[5] = 8400;
                    if (BuildArray[6] == 0)
                    {
                        BuildArray[6] = 8242;
                    }
                    if (BuildArray[7] == 0)
                    {
                        BuildArray[7] = 8242;
                    }
                    if (BuildArray[6] == 1)
                    {
                        BuildArray[6] = 8446;
                    }
                    if (BuildArray[7] == 1)
                    {
                        BuildArray[7] = 8446;
                    }
                    if (BuildArray[6] == 2)
                    {
                        BuildArray[6] = 8463;
                    }
                    if (BuildArray[7] == 2)
                    {
                        BuildArray[7] = 8463;
                    }
                    if (BuildArray[6] == 3)
                    {
                        BuildArray[6] = 8430;
                    }
                    if (BuildArray[7] == 3)
                    {
                        BuildArray[7] = 8430;
                    }
                    if (BuildArray[6] == 4)
                    {
                        BuildArray[6] = 8435;
                    }
                    if (BuildArray[7] == 4)
                    {
                        BuildArray[7] = 8435;
                    }
                    if (BuildArray[6] == 5)
                    {
                        BuildArray[6] = 8429;
                    }
                    if (BuildArray[7] == 5)
                    {
                        BuildArray[7] = 8429;
                    }
                    if (BuildArray[6] == 6)
                    {
                        BuildArray[6] = 8451;
                    }
                    if (BuildArray[7] == 6)
                    {
                        BuildArray[7] = 8451;
                    }
                    if (BuildArray[6] == 7)
                    {
                        BuildArray[6] = 8453;
                    }
                    if (BuildArray[7] == 7)
                    {
                        BuildArray[7] = 8453;
                    }
                    if (BuildArray[6] == 8)
                    {
                        BuildArray[6] = 8444;
                    }
                    if (BuildArray[7] == 8)
                    {
                        BuildArray[7] = 8444;
                    }
                }
                if (BuildArray[5] == 3 && BuildArray[0] == 8200)
                {
                    BuildArray[5] = 8300;
                    if (BuildArray[6] == 0)
                    {
                        BuildArray[6] = 8306;
                    }
                    if (BuildArray[7] == 0)
                    {
                        BuildArray[7] = 8306;
                    }
                    if (BuildArray[6] == 1)
                    {
                        BuildArray[6] = 8345;
                    }
                    if (BuildArray[7] == 1)
                    {
                        BuildArray[7] = 8345;
                    }
                    if (BuildArray[6] == 2)
                    {
                        BuildArray[6] = 8313;
                    }
                    if (BuildArray[7] == 2)
                    {
                        BuildArray[7] = 8313;
                    }
                    if (BuildArray[6] == 3)
                    {
                        BuildArray[6] = 8304;
                    }
                    if (BuildArray[7] == 3)
                    {
                        BuildArray[7] = 8304;
                    }
                    if (BuildArray[6] == 4)
                    {
                        BuildArray[6] = 8321;
                    }
                    if (BuildArray[7] == 4)
                    {
                        BuildArray[7] = 8321;
                    }
                    if (BuildArray[6] == 5)
                    {
                        BuildArray[6] = 8316;
                    }
                    if (BuildArray[7] == 5)
                    {
                        BuildArray[7] = 8316;
                    }
                    if (BuildArray[6] == 6)
                    {
                        BuildArray[6] = 8347;
                    }
                    if (BuildArray[7] == 6)
                    {
                        BuildArray[7] = 8347;
                    }
                    if (BuildArray[6] == 7)
                    {
                        BuildArray[6] = 8410;
                    }
                    if (BuildArray[7] == 7)
                    {
                        BuildArray[7] = 8410;
                    }
                    if (BuildArray[6] == 8)
                    {
                        BuildArray[6] = 8339;
                    }
                    if (BuildArray[7] == 8)
                    {
                        BuildArray[7] = 8339;
                    }
                }
            }


            if (BuildArray[0] == 3)
            {
                BuildArray[0] = 8400;
                if (BuildArray[1] == 0)
                {
                    BuildArray[1] = 8112;
                }
                if (BuildArray[1] == 1)
                {
                    BuildArray[1] = 8124;
                }
                if (BuildArray[1] == 2)
                {
                    BuildArray[1] = 8128;
                }
                if (BuildArray[2] == 0)
                {
                    BuildArray[2] = 8126;
                }
                if (BuildArray[2] == 1)
                {
                    BuildArray[2] = 8139;
                }
                if (BuildArray[2] == 2)
                {
                    BuildArray[2] = 8143;
                }
                if (BuildArray[3] == 0)
                {
                    BuildArray[3] = 8136;
                }
                if (BuildArray[3] == 1)
                {
                    BuildArray[3] = 8120;
                }
                if (BuildArray[3] == 2)
                {
                    BuildArray[3] = 8138;
                }
                if (BuildArray[4] == 0)
                {
                    BuildArray[4] = 8135;
                }
                if (BuildArray[4] == 1)
                {
                    BuildArray[4] = 8134;
                }
                if (BuildArray[4] == 2)
                {
                    BuildArray[4] = 8105;
                }
                if (BuildArray[5] == 0 && BuildArray[0] == 8400)
                {
                    BuildArray[5] = 8000;
                    if (BuildArray[6] == 0)
                    {
                        BuildArray[6] = 9101;
                    }
                    if (BuildArray[7] == 0)
                    {
                        BuildArray[7] = 9101;
                    }
                    if (BuildArray[6] == 1)
                    {
                        BuildArray[6] = 9111;
                    }
                    if (BuildArray[7] == 1)
                    {
                        BuildArray[7] = 9111;
                    }
                    if (BuildArray[6] == 2)
                    {
                        BuildArray[6] = 8009;
                    }
                    if (BuildArray[7] == 2)
                    {
                        BuildArray[7] = 8009;
                    }
                    if (BuildArray[6] == 3)
                    {
                        BuildArray[6] = 9104;
                    }
                    if (BuildArray[7] == 3)
                    {
                        BuildArray[7] = 9104;
                    }
                    if (BuildArray[6] == 4)
                    {
                        BuildArray[6] = 9105;
                    }
                    if (BuildArray[7] == 4)
                    {
                        BuildArray[7] = 9105;
                    }
                    if (BuildArray[6] == 5)
                    {
                        BuildArray[6] = 9103;
                    }
                    if (BuildArray[7] == 5)
                    {
                        BuildArray[7] = 9103;
                    }
                    if (BuildArray[6] == 6)
                    {
                        BuildArray[6] = 8014;
                    }
                    if (BuildArray[7] == 6)
                    {
                        BuildArray[7] = 8014;
                    }
                    if (BuildArray[6] == 7)
                    {
                        BuildArray[6] = 8017;
                    }
                    if (BuildArray[7] == 7)
                    {
                        BuildArray[7] = 8017;
                    }
                    if (BuildArray[6] == 8)
                    {
                        BuildArray[6] = 8299;
                    }
                    if (BuildArray[7] == 8)
                    {
                        BuildArray[7] = 8299;
                    }
                }
                if (BuildArray[5] == 1 && BuildArray[0] == 8400)
                {
                    BuildArray[5] = 8100;
                    if (BuildArray[6] == 0)
                    {
                        BuildArray[6] = 8126;
                    }
                    if (BuildArray[7] == 0)
                    {
                        BuildArray[7] = 8126;
                    }
                    if (BuildArray[6] == 1)
                    {
                        BuildArray[6] = 8139;
                    }
                    if (BuildArray[7] == 1)
                    {
                        BuildArray[7] = 8139;
                    }
                    if (BuildArray[6] == 2)
                    {
                        BuildArray[6] = 8143;
                    }
                    if (BuildArray[7] == 2)
                    {
                        BuildArray[7] = 8143;
                    }
                    if (BuildArray[6] == 3)
                    {
                        BuildArray[6] = 8136;
                    }
                    if (BuildArray[7] == 3)
                    {
                        BuildArray[7] = 8136;
                    }
                    if (BuildArray[6] == 4)
                    {
                        BuildArray[6] = 8120;
                    }
                    if (BuildArray[7] == 4)
                    {
                        BuildArray[7] = 8120;
                    }
                    if (BuildArray[6] == 5)
                    {
                        BuildArray[6] = 8138;
                    }
                    if (BuildArray[7] == 5)
                    {
                        BuildArray[7] = 8138;
                    }
                    if (BuildArray[6] == 6)
                    {
                        BuildArray[6] = 8135;
                    }
                    if (BuildArray[7] == 6)
                    {
                        BuildArray[7] = 8135;
                    }
                    if (BuildArray[6] == 7)
                    {
                        BuildArray[6] = 8134;
                    }
                    if (BuildArray[7] == 7)
                    {
                        BuildArray[7] = 8134;
                    }
                    if (BuildArray[6] == 8)
                    {
                        BuildArray[6] = 8105;
                    }
                    if (BuildArray[7] == 8)
                    {
                        BuildArray[7] = 8105;
                    }
                }
                if (BuildArray[5] == 2 && BuildArray[0] == 8400)
                {
                    BuildArray[5] = 8200;
                    if (BuildArray[6] == 0)
                    {
                        BuildArray[6] = 8224;
                    }
                    if (BuildArray[7] == 0)
                    {
                        BuildArray[7] = 8224;
                    }
                    if (BuildArray[6] == 1)
                    {
                        BuildArray[6] = 8226;
                    }
                    if (BuildArray[7] == 1)
                    {
                        BuildArray[7] = 8226;
                    }
                    if (BuildArray[6] == 2)
                    {
                        BuildArray[6] = 8243;
                    }
                    if (BuildArray[7] == 2)
                    {
                        BuildArray[7] = 8243;
                    }
                    if (BuildArray[6] == 3)
                    {
                        BuildArray[6] = 8210;
                    }
                    if (BuildArray[7] == 3)
                    {
                        BuildArray[7] = 8210;
                    }
                    if (BuildArray[6] == 4)
                    {
                        BuildArray[6] = 8234;
                    }
                    if (BuildArray[7] == 4)
                    {
                        BuildArray[7] = 8234;
                    }
                    if (BuildArray[6] == 5)
                    {
                        BuildArray[6] = 8233;
                    }
                    if (BuildArray[7] == 5)
                    {
                        BuildArray[7] = 8233;
                    }
                    if (BuildArray[6] == 6)
                    {
                        BuildArray[6] = 8237;
                    }
                    if (BuildArray[7] == 6)
                    {
                        BuildArray[7] = 8237;
                    }
                    if (BuildArray[6] == 7)
                    {
                        BuildArray[6] = 8232;
                    }
                    if (BuildArray[7] == 7)
                    {
                        BuildArray[7] = 8232;
                    }
                    if (BuildArray[6] == 8)
                    {
                        BuildArray[6] = 8236;
                    }
                    if (BuildArray[7] == 8)
                    {
                        BuildArray[7] = 8236;
                    }
                }
                if (BuildArray[5] == 3 && BuildArray[0] == 8400)
                {
                    BuildArray[5] = 8300;
                    if (BuildArray[6] == 0)
                    {
                        BuildArray[6] = 8306;
                    }
                    if (BuildArray[7] == 0)
                    {
                        BuildArray[7] = 8306;
                    }
                    if (BuildArray[6] == 1)
                    {
                        BuildArray[6] = 8345;
                    }
                    if (BuildArray[7] == 1)
                    {
                        BuildArray[7] = 8345;
                    }
                    if (BuildArray[6] == 2)
                    {
                        BuildArray[6] = 8313;
                    }
                    if (BuildArray[7] == 2)
                    {
                        BuildArray[7] = 8313;
                    }
                    if (BuildArray[6] == 3)
                    {
                        BuildArray[6] = 8304;
                    }
                    if (BuildArray[7] == 3)
                    {
                        BuildArray[7] = 8304;
                    }
                    if (BuildArray[6] == 4)
                    {
                        BuildArray[6] = 8321;
                    }
                    if (BuildArray[7] == 4)
                    {
                        BuildArray[7] = 8321;
                    }
                    if (BuildArray[6] == 5)
                    {
                        BuildArray[6] = 8316;
                    }
                    if (BuildArray[7] == 5)
                    {
                        BuildArray[7] = 8316;
                    }
                    if (BuildArray[6] == 6)
                    {
                        BuildArray[6] = 8347;
                    }
                    if (BuildArray[7] == 6)
                    {
                        BuildArray[7] = 8347;
                    }
                    if (BuildArray[6] == 7)
                    {
                        BuildArray[6] = 8410;
                    }
                    if (BuildArray[7] == 7)
                    {
                        BuildArray[7] = 8410;
                    }
                    if (BuildArray[6] == 8)
                    {
                        BuildArray[6] = 8339;
                    }
                    if (BuildArray[7] == 8)
                    {
                        BuildArray[7] = 8339;
                    }
                }
            }


            if (BuildArray[0] == 3)
            {
                BuildArray[0] = 8300;
                if (BuildArray[1] == 0)
                {
                    BuildArray[1] = 8112;
                }
                if (BuildArray[1] == 1)
                {
                    BuildArray[1] = 8124;
                }
                if (BuildArray[1] == 2)
                {
                    BuildArray[1] = 8128;
                }
                if (BuildArray[2] == 0)
                {
                    BuildArray[2] = 8126;
                }
                if (BuildArray[2] == 1)
                {
                    BuildArray[2] = 8139;
                }
                if (BuildArray[2] == 2)
                {
                    BuildArray[2] = 8143;
                }
                if (BuildArray[3] == 0)
                {
                    BuildArray[3] = 8136;
                }
                if (BuildArray[3] == 1)
                {
                    BuildArray[3] = 8120;
                }
                if (BuildArray[3] == 2)
                {
                    BuildArray[3] = 8138;
                }
                if (BuildArray[4] == 0)
                {
                    BuildArray[4] = 8135;
                }
                if (BuildArray[4] == 1)
                {
                    BuildArray[4] = 8134;
                }
                if (BuildArray[4] == 2)
                {
                    BuildArray[4] = 8105;
                }
                if (BuildArray[5] == 0 && BuildArray[0] == 8300)
                {
                    BuildArray[5] = 8000;
                    if (BuildArray[6] == 0)
                    {
                        BuildArray[6] = 9101;
                    }
                    if (BuildArray[7] == 0)
                    {
                        BuildArray[7] = 9101;
                    }
                    if (BuildArray[6] == 1)
                    {
                        BuildArray[6] = 9111;
                    }
                    if (BuildArray[7] == 1)
                    {
                        BuildArray[7] = 9111;
                    }
                    if (BuildArray[6] == 2)
                    {
                        BuildArray[6] = 8009;
                    }
                    if (BuildArray[7] == 2)
                    {
                        BuildArray[7] = 8009;
                    }
                    if (BuildArray[6] == 3)
                    {
                        BuildArray[6] = 9104;
                    }
                    if (BuildArray[7] == 3)
                    {
                        BuildArray[7] = 9104;
                    }
                    if (BuildArray[6] == 4)
                    {
                        BuildArray[6] = 9105;
                    }
                    if (BuildArray[7] == 4)
                    {
                        BuildArray[7] = 9105;
                    }
                    if (BuildArray[6] == 5)
                    {
                        BuildArray[6] = 9103;
                    }
                    if (BuildArray[7] == 5)
                    {
                        BuildArray[7] = 9103;
                    }
                    if (BuildArray[6] == 6)
                    {
                        BuildArray[6] = 8014;
                    }
                    if (BuildArray[7] == 6)
                    {
                        BuildArray[7] = 8014;
                    }
                    if (BuildArray[6] == 7)
                    {
                        BuildArray[6] = 8017;
                    }
                    if (BuildArray[7] == 7)
                    {
                        BuildArray[7] = 8017;
                    }
                    if (BuildArray[6] == 8)
                    {
                        BuildArray[6] = 8299;
                    }
                    if (BuildArray[7] == 8)
                    {
                        BuildArray[7] = 8299;
                    }
                }
                if (BuildArray[5] == 1 && BuildArray[0] == 8300)
                {
                    BuildArray[5] = 8100;
                    if (BuildArray[6] == 0)
                    {
                        BuildArray[6] = 8126;
                    }
                    if (BuildArray[7] == 0)
                    {
                        BuildArray[7] = 8126;
                    }
                    if (BuildArray[6] == 1)
                    {
                        BuildArray[6] = 8139;
                    }
                    if (BuildArray[7] == 1)
                    {
                        BuildArray[7] = 8139;
                    }
                    if (BuildArray[6] == 2)
                    {
                        BuildArray[6] = 8143;
                    }
                    if (BuildArray[7] == 2)
                    {
                        BuildArray[7] = 8143;
                    }
                    if (BuildArray[6] == 3)
                    {
                        BuildArray[6] = 8136;
                    }
                    if (BuildArray[7] == 3)
                    {
                        BuildArray[7] = 8136;
                    }
                    if (BuildArray[6] == 4)
                    {
                        BuildArray[6] = 8120;
                    }
                    if (BuildArray[7] == 4)
                    {
                        BuildArray[7] = 8120;
                    }
                    if (BuildArray[6] == 5)
                    {
                        BuildArray[6] = 8138;
                    }
                    if (BuildArray[7] == 5)
                    {
                        BuildArray[7] = 8138;
                    }
                    if (BuildArray[6] == 6)
                    {
                        BuildArray[6] = 8135;
                    }
                    if (BuildArray[7] == 6)
                    {
                        BuildArray[7] = 8135;
                    }
                    if (BuildArray[6] == 7)
                    {
                        BuildArray[6] = 8134;
                    }
                    if (BuildArray[7] == 7)
                    {
                        BuildArray[7] = 8134;
                    }
                    if (BuildArray[6] == 8)
                    {
                        BuildArray[6] = 8105;
                    }
                    if (BuildArray[7] == 8)
                    {
                        BuildArray[7] = 8105;
                    }
                }
                if (BuildArray[5] == 2 && BuildArray[0] == 8300)
                {
                    BuildArray[5] = 8200;
                    if (BuildArray[6] == 0)
                    {
                        BuildArray[6] = 8224;
                    }
                    if (BuildArray[7] == 0)
                    {
                        BuildArray[7] = 8224;
                    }
                    if (BuildArray[6] == 1)
                    {
                        BuildArray[6] = 8226;
                    }
                    if (BuildArray[7] == 1)
                    {
                        BuildArray[7] = 8226;
                    }
                    if (BuildArray[6] == 2)
                    {
                        BuildArray[6] = 8243;
                    }
                    if (BuildArray[7] == 2)
                    {
                        BuildArray[7] = 8243;
                    }
                    if (BuildArray[6] == 3)
                    {
                        BuildArray[6] = 8210;
                    }
                    if (BuildArray[7] == 3)
                    {
                        BuildArray[7] = 8210;
                    }
                    if (BuildArray[6] == 4)
                    {
                        BuildArray[6] = 8234;
                    }
                    if (BuildArray[7] == 4)
                    {
                        BuildArray[7] = 8234;
                    }
                    if (BuildArray[6] == 5)
                    {
                        BuildArray[6] = 8233;
                    }
                    if (BuildArray[7] == 5)
                    {
                        BuildArray[7] = 8233;
                    }
                    if (BuildArray[6] == 6)
                    {
                        BuildArray[6] = 8237;
                    }
                    if (BuildArray[7] == 6)
                    {
                        BuildArray[7] = 8237;
                    }
                    if (BuildArray[6] == 7)
                    {
                        BuildArray[6] = 8232;
                    }
                    if (BuildArray[7] == 7)
                    {
                        BuildArray[7] = 8232;
                    }
                    if (BuildArray[6] == 8)
                    {
                        BuildArray[6] = 8236;
                    }
                    if (BuildArray[7] == 8)
                    {
                        BuildArray[7] = 8236;
                    }
                }
                if (BuildArray[5] == 3 && BuildArray[0] == 8300)
                {
                    BuildArray[5] = 8400;
                    if (BuildArray[6] == 0)
                    {
                        BuildArray[6] = 8242;
                    }
                    if (BuildArray[7] == 0)
                    {
                        BuildArray[7] = 8242;
                    }
                    if (BuildArray[6] == 1)
                    {
                        BuildArray[6] = 8446;
                    }
                    if (BuildArray[7] == 1)
                    {
                        BuildArray[7] = 8446;
                    }
                    if (BuildArray[6] == 2)
                    {
                        BuildArray[6] = 8463;
                    }
                    if (BuildArray[7] == 2)
                    {
                        BuildArray[7] = 8463;
                    }
                    if (BuildArray[6] == 3)
                    {
                        BuildArray[6] = 8430;
                    }
                    if (BuildArray[7] == 3)
                    {
                        BuildArray[7] = 8430;
                    }
                    if (BuildArray[6] == 4)
                    {
                        BuildArray[6] = 8435;
                    }
                    if (BuildArray[7] == 4)
                    {
                        BuildArray[7] = 8435;
                    }
                    if (BuildArray[6] == 5)
                    {
                        BuildArray[6] = 8429;
                    }
                    if (BuildArray[7] == 5)
                    {
                        BuildArray[7] = 8429;
                    }
                    if (BuildArray[6] == 6)
                    {
                        BuildArray[6] = 8451;
                    }
                    if (BuildArray[7] == 6)
                    {
                        BuildArray[7] = 8451;
                    }
                    if (BuildArray[6] == 7)
                    {
                        BuildArray[6] = 8453;
                    }
                    if (BuildArray[7] == 7)
                    {
                        BuildArray[7] = 8453;
                    }
                    if (BuildArray[6] == 8)
                    {
                        BuildArray[6] = 8444;
                    }
                    if (BuildArray[7] == 8)
                    {
                        BuildArray[7] = 8444;
                    }
                }
            }


            return BuildArray;
        }
    }
}
