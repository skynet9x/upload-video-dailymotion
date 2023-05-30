using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Text.RegularExpressions;
using System.Threading;
using upload_video_dailymotion.module;

namespace upload_video_dailymotion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        Thread th_run;

        // Load Global System ... //
        private void Form1_Load(object sender, EventArgs e)
        {
            // Load config //
            if (File.Exists("data/config.json") == true)
            {
                JObject tmp = JObject.Parse(File.ReadAllText("data/config.json"));
                Global.config = tmp;
            };

            // Load Data //
            if (File.Exists("data/setting.json"))
            {
                Global.config = JObject.Parse(File.ReadAllText("data/setting.json"));
            };

        }
        

        
        private void btn_start_Click(object sender, EventArgs e)
        {
            btn_start.Enabled = false;
            th_run = new Thread(() => {
                start();
            }) { IsBackground = true };
            th_run.Start();
        }

        private void start()
        {
            DirectoryInfo d = new DirectoryInfo("dailymotion/");
            FileInfo[] Files = d.GetFiles("*.json");

            while(true)
            {
                foreach (FileInfo file in Files)
                {
                    JObject dataChannel = JObject.Parse(File.ReadAllText(file.FullName));
                    DateTime now = DateTime.Now;
                    DateTime UpLoad = DateTime.Parse(dataChannel["upload_video"].ToString());

                    if (now.Subtract(UpLoad).TotalDays > 1 )
                    {
                        dataChannel["today"] = 0;
                    };

                    if (dataChannel["status"].ToString() == "START" && int.Parse(dataChannel["today"].ToString()) < int.Parse(dataChannel["daily"].ToString()))
                    {
                        for (int j = 0; j < dataChannel["playlist_video"].Count(); j++)
                        {
                            JObject data = (JObject)dataChannel["playlist_video"][j];
                            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"geckodriver-v0.31.0-win64", "geckodriver.exe");

                            service.FirefoxBinaryPath = Global.config["dir_firefox"].ToString();
                            service.HideCommandPromptWindow = true;

                            FirefoxProfileManager FF = new FirefoxProfileManager();

                            FirefoxOptions Option = new FirefoxOptions();
                            Option.Profile = FF.GetProfile(dataChannel["profile"].ToString());

                            IWebDriver driver = new FirefoxDriver(service, Option);
                            driver.Navigate().GoToUrl("https://www.dailymotion.com/partner/" + dataChannel["id"].ToString() + "/media/video/upload");

                            string playlist = data["playlist"].ToString();

                            // Get Video //
                            API.youtube.playlist API_playlist = new API.youtube.playlist();
                            JObject videos = API_playlist.video(playlist);

                            for (int i = videos["items"].Count() - 1; i > -1; i--)
                            {
                                if (int.Parse(dataChannel["today"].ToString()) < int.Parse(dataChannel["daily"].ToString()))
                                {
                                    JObject item = (JObject)videos["items"][i];
                                    DateTime video_public = DateTime.Parse(item["snippet"]["publishedAt"].ToString());

                                    if (DateTime.Compare(video_public.AddHours(7), DateTime.Parse(data["upload_video"].ToString())) > 0)
                                    {
                                        // Upload video //
                                        controller.downloadvideo dl = new controller.downloadvideo();
                                        string fileVideo = dl.download(item["snippet"]["resourceId"]["videoId"].ToString());

                                        Thread.Sleep(2 * 1000);

                                        driver.Navigate().GoToUrl("https://www.dailymotion.com/partner/" + dataChannel["id"].ToString() + "/media/video/upload");
                                        Thread.Sleep(10 * 1000);

                                        IWebElement upload_file = driver.FindElement(By.Id("upload__upload-zone")).FindElement(By.TagName("input"));

                                        if (File.Exists(fileVideo) == true)
                                        {
                                            upload_file.SendKeys(fileVideo);
                                            Thread.Sleep(10 * 1000);

                                            // Category //
                                            driver.FindElements(By.ClassName("ant-select-selection__rendered"))[2].Click();
                                            Thread.Sleep(1 * 1000);
                                            driver.FindElement(By.ClassName("ant-select-dropdown")).FindElements(By.TagName("li"))[10].Click();

                                            // Title //
                                            Thread.Sleep(1 * 1000);
                                            driver.FindElement(By.Name("title")).Clear();
                                            driver.FindElement(By.Name("title")).SendKeys(item["snippet"]["title"].ToString());

                                            // Description //
                                            Thread.Sleep(1 * 1000);
                                            driver.FindElement(By.Name("description")).Clear();
                                            driver.FindElement(By.Name("description")).SendKeys(item["snippet"]["description"].ToString());
                                            Thread.Sleep(1 * 1000);

                                            // Tags //
                                            string line_tags = apitags.tags(item["snippet"]["title"].ToString());
                                            driver.FindElement(By.ClassName("ant-select-search__field")).Clear();
                                            driver.FindElement(By.ClassName("ant-select-search__field")).SendKeys(line_tags);
                                            driver.FindElement(By.Name("description")).Click();

                                            var js = (IJavaScriptExecutor)driver;
                                            js.ExecuteScript("window.scrollTo(0, 0)");

                                            // Save & public video //
                                            bool btnSave = true;
                                            while (btnSave)
                                            {
                                                try
                                                {
                                                    driver.FindElement(By.Name("submit")).Click();
                                                    btnSave = false;
                                                } catch (Exception e)
                                                {
                                                    Thread.Sleep(1000);
                                                };
                                            };
                                        };

                                        // Update //
                                        data["upload_video"] = video_public.AddHours(7).ToString("yyyy/MM/dd HH:mm:ss");
                                        dataChannel["today"] = int.Parse(dataChannel["today"].ToString()) + 1;
                                        dataChannel["upload_video"] = video_public.AddHours(7).ToString("yyyy/MM/dd HH:mm:ss");
                                        dataChannel["playlist_video"][j] = data;

                                        File.WriteAllText("dailymotion/" + dataChannel["id"].ToString() + ".json", dataChannel.ToString());
                                        Thread.Sleep(5 * 1000);
                                    };

                                } else {
                                    break;
                                };
                            };

                            driver.Quit();
                        };
                    };
                    
                    Thread.Sleep(10 * 1000);
                };

                Thread.Sleep(60 * 1000);
            };
        }

        private void save_setting_dailymotion()
        {
            new Thread(() => {
                //Give the path of the geckodriver.exe    
                FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"geckodriver-v0.31.0-win64", "geckodriver.exe");

                service.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";
                service.HideCommandPromptWindow = true;

                // FirefoxProfile ProfileFF = new FirefoxProfile(txt_firefox_profile.Text);
                FirefoxProfileManager FF = new FirefoxProfileManager();

                FirefoxOptions Option = new FirefoxOptions();
                Option.Profile = FF.GetProfile(txt_firefox_profile.Text);

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
                    item["playlist"] = txt_playlist.Text;
                    item["upload_video"] = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                    playlists.Add(item);

                    info["id"] = mc[0].Groups[1].ToString();
                    info["profile"] = txt_firefox_profile.Text;
                    info["daily"] = txt_count_video_upload_daily.Text;
                    info["today"] = "0";
                    info["status"] = txt_status.Text;
                    info["playlist_video"] = playlists;
                    info["delay"] = txt_delay.Text;
                    info["created_date"] = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

                    File.WriteAllText("dailymotion/" + info["id"].ToString() + ".json", info.ToString());
                    File.WriteAllText("dailymotion/videos/" + info["id"].ToString() + ".json", String.Join("\n", videos.ToArray()));

                };
                driver.Close();
            })
            { IsBackground = true }.Start();
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new setting();
            f.Show();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new form_add_profile();
            f.Show();
        }
    }
}
