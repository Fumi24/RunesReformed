using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyHttp.Http;
using System.Management;

namespace RunesReformed1._1
{
    public partial class RunesReformed : Form
    {
        public static string token;
        public static string port;

        public class Champion
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public Champion(int id, string name)
            {
                Id = id;
                Name = name;
            }

        }

        public class RunePage
        {
            public string _pageName { get; set; }
            public int _runeStart { get; set; }
            public int _rune1 { get; set; }
            public int _rune2 { get; set; }
            public int _rune3 { get; set; }
            public int _rune4 { get; set; }
            public int _runeSecondary { get; set; }
            public int _rune5 { get; set; }
            public int _rune6 { get; set; }

            public RunePage(string name, int start, int rune1, int rune2, int rune3, int rune4, int secondary,
                int rune5, int rune6)
            {
                _pageName = name;
                _runeStart = start;
                _rune1 = rune1;
                _rune2 = rune2;
                _rune3 = rune3;
                _rune4 = rune4;
                _runeSecondary = secondary;
                _rune5 = rune5;
                _rune6 = rune6;
            }
        }

        public List<string> ChampionList = new List<string>();
        public List<RunePage> Pagelist = new List<RunePage>();
        public List<string> Pagenamelist = new List<string>();

        public RunesReformed()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getchamps();
            getpages();
            Champbox.DataSource = ChampionList;
            Leagueconnect();
            LoadOfflinePages();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pagebox.Items.Clear();
            string champ = Champbox.SelectedItem.ToString();

            foreach (var rune in Pagenamelist)
            {
                if (Pagenamelist.Count == 0)
                {

                }
                else
                {
                    if (rune.Contains(champ))
                    {
                        Pagebox.Items.Add(rune);
                    }
                }
            }
        }

        public void getchamps()
        {
            var http = new HttpClient();
            http.Request.Accept = HttpContentTypes.ApplicationJson;
            var response = http.Get("https://webapichampions.azurewebsites.net/api/values");
            var getchamps = response.DynamicBody;

            foreach (var champ in getchamps)
            {
                Champion ImportChampBox = new Champion(champ._Id, champ._DisplayName);
                ChampionList.Add(ImportChampBox.Name);
                ChampionList.Sort();
            }
        }

        public void getpages()
        {
            var http = new HttpClient();
            http.Request.Accept = HttpContentTypes.ApplicationJson;
            var response = http.Get("https://wepapirunepages.azurewebsites.net/api/values");
            var getpages = response.DynamicBody;

            foreach (var page in getpages)
            {
                RunePage ImportPageBox = new RunePage(page.PageName, page.Runestart, page.Rune1, page.Rune2, page.Rune3,
                    page.Rune4, page.RuneSecondary, page.Rune5, page.Rune6);
                Pagelist.Add(ImportPageBox);
                Pagenamelist.Add(page.PageName);
            }
        }

        public void LoadOfflinePages()
        {
            string path = Environment.CurrentDirectory + @"\Runepages.txt";
            if (!File.Exists(path))
            {
                File.CreateText(path);
            }
            else
            {
                foreach (string data in File.ReadAllLines(path))
                {
                    string[] runes = data.Split(',');
                    RunePage import = new RunePage(
                        runes[0], Convert.ToInt32(runes[1]), Convert.ToInt32(runes[2]),
                        Convert.ToInt32(runes[3]), Convert.ToInt32(runes[4]), Convert.ToInt32(runes[5]),
                        Convert.ToInt32(runes[6]), Convert.ToInt32(runes[7]), Convert.ToInt32(runes[8]));
                    Pagelist.Add(import);
                    Pagenamelist.Add(runes[0]);
                }
            }
        }

        public void Leagueconnect()
        {
            var process = Process.GetProcessesByName("LeagueClientUx");
            if (process.Length == 0)
            {
                string msgbox =
                    "Could not find the League of Legends process, is League of Legends running?";
                MessageBox.Show(msgbox);
                this.Close();
            }
            else
            {
                foreach (var getid in process)
                {
                    using (ManagementObjectSearcher mos = new ManagementObjectSearcher(
                        "SELECT CommandLine FROM Win32_Process WHERE ProcessId = " + getid.Id))
                    {
                        foreach (ManagementObject mo in mos.Get())
                        {
                            string data = (mo["CommandLine"].ToString());
                            string[] CommandlineArray = data.Split('"');

                            foreach (var atributes in CommandlineArray)
                            {
                                if (atributes.Contains("token"))
                                {
                                    string[] token = atributes.Split('=');
                                    RunesReformed.token = token[1];
                                }
                                if (atributes.Contains("port"))
                                {
                                    string[] port = atributes.Split('=');
                                    RunesReformed.port = port[1];
                                }
                            }
                        }
                    }
                }
            }
        }

        private void Runebtn_Click(object sender, EventArgs e)
        {
            if (Pagebox.SelectedItem == null)
                Pagebox.SelectedIndex = 0;
            String selectedPage = Pagebox.SelectedItem.ToString();

            RunePage runes = Pagelist.Find(r => r._pageName == selectedPage);

            try
            {
                int Runestart = runes._runeStart;
                string name = runes._pageName;
                int rune1 = runes._rune1;
                int rune2 = runes._rune2;
                int rune3 = runes._rune3;
                int rune4 = runes._rune4;
                int rune5 = runes._rune5;
                int rune6 = runes._rune6;
                int secondary = runes._runeSecondary;

                var inputLCUx = @"{""name"":""" + name + "\",\"primaryStyleId\":" + Runestart + ",\"selectedPerkIds\": [" +
                                rune1 + "," + rune2 + "," + rune3 + "," + rune4 + "," + rune5 + "," + rune6 +
                                "],\"subStyleId\":" + secondary + "}";

                string password = token;

                var riotHttp = new HttpClient();
                riotHttp.Request.Accept = HttpContentTypes.ApplicationJson;
                riotHttp.Request.SetBasicAuthentication("riot", password);

                riotHttp.Post("https://127.0.0.1:" + port + "/lol-perks/v1/pages", inputLCUx, HttpContentTypes.ApplicationJson);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Something somewhere went wrong, show this to the admin " + exception.Message);
            }
        }

        private void AddPage_Click(object sender, EventArgs e)
        {
            string Newpage = Microsoft.VisualBasic.Interaction.InputBox("Here you can add a page, remember to include every rune and the name of the champion.", "RunesReformed", "Twisted Fate, 5, 2, 3, 1, 4, 3, 3");


            string[] newpageStrings = Newpage.Split(',');
            RunePage import = new RunePage(
                newpageStrings[0], Convert.ToInt32(newpageStrings[1]), Convert.ToInt32(newpageStrings[2]),
                Convert.ToInt32(newpageStrings[3]), Convert.ToInt32(newpageStrings[4]),
                Convert.ToInt32(newpageStrings[5]),
                Convert.ToInt32(newpageStrings[6]), Convert.ToInt32(newpageStrings[7]),
                Convert.ToInt32(newpageStrings[8]));
            Pagelist.Add(import);
            Pagenamelist.Add(newpageStrings[0]);

            StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + @"\Runepages.txt", true);
            sw.WriteLine(Newpage);
            sw.Flush();
            sw.Close();
        }
    }
}
