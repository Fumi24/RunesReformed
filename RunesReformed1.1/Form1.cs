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
using System.Security.Principal;
using System.Windows.Forms;
using EasyHttp.Http;
using System.Management;
using JsonFx.Json;
using RunesReformed1._1.API;
using RunesReformed1.Models;

namespace RunesReformed1._1
{
    public partial class RunesReformed : Form
    {
        public static string token;
        public static string port;
        public static HttpClient http;

        GetChamps GC = new GetChamps();
        GetPages GP = new GetPages();
        public List<Champion> champs = new List<Champion>();
        public List<string> ChampionList = new List<string>();
        public List<Pages> Pagelist = new List<Pages>();
        public List<string> Pagenamelist = new List<string>();

        public RunesReformed()
        {
            http = new HttpClient();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!(new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator)))
            {
                MessageBox.Show("App not running with administrator privilege. Please run this app as administrator");
                this.Close();
            }
            updater();
            Leagueconnect();
            champs = GC.GetChampions();
            Pagelist = GP.GetRunePages();

            foreach (var item in champs)
            {
                ChampionList.Add(item.Champname);
            }
            foreach (var item in Pagelist)
            {
                Pagenamelist.Add(item.PageName);
            }
            Champbox.DataSource = ChampionList;
            Pagenamelist.Sort();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pagebox.Items.Clear();
            string champ = Champbox.SelectedItem.ToString();

            Champion c = champs.Find(x => x.Champname == champ);

            List<Pages> p = Pagelist.FindAll(x => x.Id == c.Id);

            foreach (var item in p)
            {
                Pagebox.Items.Add(item.PageName);
            }
        }

        public void updater()
        {
            http.Request.Accept = HttpContentTypes.ApplicationJson;
            var response = http.Get("https://api.github.com/repos/Fumi24/RunesReformed/releases");
            var getid = response.DynamicBody;
            var updateid = getid[0].tag_name;

            if (updateid != "1.4.1")
            {
                string messagetext =
                    "Update available, Press OK to download the new version";
                DialogResult boxanswer = MessageBox.Show(messagetext, "updater", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                if (boxanswer == DialogResult.OK)
                {
                    Process.Start("https://github.com/Fumi24/RunesReformed/releases/latest");
                }
            }
        }

        public void DeletePage()
        {
            if (DeleteCheck.Checked)
            {
                http = new HttpClient();
                HttpResponse response = null;
                try
                {
                    http.Request.Accept = HttpContentTypes.ApplicationJson;
                    http.Request.ForceBasicAuth = true;
                    http.Request.SetBasicAuthentication("riot", token);
                    response = http.Get("https://127.0.0.1:" + port + "/lol-perks/v1/currentpage"); 
                }
                catch(Exception e) // lol client closed / reopened
                {
                    Leagueconnect();
                    http.Request.Accept = HttpContentTypes.ApplicationJson;
                    http.Request.ForceBasicAuth = true;
                    http.Request.SetBasicAuthentication("riot", token);
                    response = http.Get("https://127.0.0.1:" + port + "/lol-perks/v1/currentpage");
                }
                var currentpage = response.DynamicBody;

                int deleteid = currentpage.id;

                if (deleteid == 54 || deleteid == 53 || deleteid == 52 || deleteid == 51 || deleteid == 50)
                    MessageBox.Show("Cant Delete Pages, Looks like its only Riots default pages left, if you know this is wrong, click the page once so it gets set to current.");
                else
                {
                    http.Delete("https://127.0.0.1:" + port + "/lol-perks/v1/pages/" + deleteid);
                }
            }
        }



        public void Leagueconnect()
        {
            var process = Process.GetProcessesByName("LeagueClientUx");
            if (process.Length != 0)
            {
                foreach (var getid in process)
                {
                    using (ManagementObjectSearcher mos = new ManagementObjectSearcher(
                        "SELECT CommandLine FROM Win32_Process WHERE ProcessId = " + getid.Id))
                    {
                        foreach (ManagementObject mo in mos.Get())
                        {
                            if (mo["CommandLine"] != null)
                            {
                                string data = (mo["CommandLine"].ToString());
                                string[] CommandlineArray = data.Split('"');

                                foreach (var attributes in CommandlineArray)
                                {
                                    if (attributes.Contains("token") || attributes.Contains("remoting-auth-token"))
                                    {
                                        string[] token = attributes.Split('=');
                                        RunesReformed.token = token[1];
                                    }
                                    if (attributes.Contains("port") || attributes.Contains("app-port"))
                                    {
                                        string[] port = attributes.Split('=');
                                        RunesReformed.port = port[1];
                                    }
                                }
                                if (string.IsNullOrWhiteSpace(RunesReformed.token) || string.IsNullOrWhiteSpace(RunesReformed.port))
                                {
                                    MessageBox.Show("League of Legends process is detected but no information can be extracted.");
                                    this.Close();
                                }
                                return;
                            }
                        }
                    }
                }
            }
            // We cannot retrieve necessary information to make the app work, can close here.
            MessageBox.Show("Could not find the League of Legends process, is League of Legends running?");
            this.Close();
        }

        private void Runebtn_Click(object sender, EventArgs e)
        {
            DeletePage();
            if (Pagebox.SelectedItem == null)
                Pagebox.SelectedIndex = 0;
            var selectedPage = Pagebox.SelectedItem.ToString();
            var index = Pagebox.SelectedIndex;

            Champion c = champs.Find(x => x.Champname == Champbox.SelectedValue.ToString());
            List<Pages> runes = Pagelist.FindAll(p => p.Id == c.Id);
            Pages correctrunes = runes[index];

            try
            {
                long Runestart = correctrunes.RuneStart;
                string name = correctrunes.PageName;
                long rune1 = correctrunes.Rune1;
                long rune2 = correctrunes.Rune2;
                long rune3 = correctrunes.Rune3;
                long rune4 = correctrunes.Rune4;
                long rune5 = correctrunes.Rune5;
                long rune6 = correctrunes.Rune6;
                long secondary = correctrunes.RuneSecondary;

                var inputLCUx = @"{""name"":""" + name + "\",\"primaryStyleId\":" + Runestart + ",\"selectedPerkIds\": [" +
                                rune1 + "," + rune2 + "," + rune3 + "," + rune4 + "," + rune5 + "," + rune6 +
                                "],\"subStyleId\":" + secondary + "}";

                HttpResponse response = null;
                try
                {
                    string password = token;

                    http.Request.Accept = HttpContentTypes.ApplicationJson;
                    http.Request.SetBasicAuthentication("riot", password);

                    response = http.Post("https://127.0.0.1:" + port + "/lol-perks/v1/pages", inputLCUx, HttpContentTypes.ApplicationJson);
                }
                catch (Exception e2)
                {
                    Leagueconnect();
                    string password = token;

                    http.Request.Accept = HttpContentTypes.ApplicationJson;
                    http.Request.SetBasicAuthentication("riot", password);

                    response = http.Post("https://127.0.0.1:" + port + "/lol-perks/v1/pages", inputLCUx, HttpContentTypes.ApplicationJson);
                }
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    var error = response.StaticBody<Error>();
                    if (error.message.Equals("Max pages reached"))
                        MessageBox.Show("Max Pages Reached");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        public class Error
        {
            [JsonName("errorCode")]
            public string errorCode { get; set; }
            [JsonName("httpStatus")]
            public int httpStatus { get; set; }
            [JsonName("message")]
            public string message { get; set; }

        }
        private void DeleteCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Githublink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Fumi24/RunesReformed");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
