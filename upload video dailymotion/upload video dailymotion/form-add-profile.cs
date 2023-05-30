using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace upload_video_dailymotion
{
    public partial class form_add_profile : Form
    {
        public form_add_profile()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void save_setting_dailymotion()
        {
            string name_profile = "";
            string plat_form = "";
            string network_proxy = "";
            string network_proxy_value = "";
            int limit_video_day = 10;
            int delay_video = 3600;
            string user_agent = "";
            string media_dir = "";
            new Thread(() => {
                //Give the path of the geckodriver.exe    
                FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"geckodriver-v0.31.0-win64", "geckodriver.exe");

                service.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";
                service.HideCommandPromptWindow = true;

                // FirefoxProfile ProfileFF = new FirefoxProfile(txt_firefox_profile.Text);
                FirefoxProfileManager FF = new FirefoxProfileManager();

                FirefoxOptions Option = new FirefoxOptions();
                Option.Profile = FF.GetProfile(name_profile);
                IWebDriver driver = new FirefoxDriver(service, Option);
                driver.Navigate().GoToUrl("https://www.dailymotion.com/partner");

                Thread.Sleep(10 * 1000);
                // get Url //
                if (Regex.IsMatch(driver.Url.ToString(), "partner/(.+)/media/video"))
                {
                    MatchCollection mc = Regex.Matches(driver.Url.ToString(), "partner/(.+)/media/video");

                    // Save Info //
                    List<string> videos = new List<string>();

                    JObject info = new JObject();
                    JArray playlists = new JArray();
                    JObject item = new JObject();
                    info["created_date"] = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

                    File.WriteAllText("dailymotion/" + info["id"].ToString() + ".json", info.ToString());
                    File.WriteAllText("dailymotion/videos/" + info["id"].ToString() + ".json", String.Join("\n", videos.ToArray()));

                };
                driver.Close();
            })
            { IsBackground = true }.Start();

        }
    }
}
