using Newtonsoft.Json.Linq;
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

namespace upload_video_dailymotion
{
    public partial class setting : Form
    {
        public setting()
        {
            InitializeComponent();
        }

        private void setting_Load(object sender, EventArgs e)
        {
            if (File.Exists("data/setting.json"))
            {
                JObject data = JObject.Parse(File.ReadAllText("data/setting.json"));
                txt_dir_firefox.Text = data["dir_firefox"].ToString();
                txt_dir_save_video.Text = data["dir_video"].ToString();
            };
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            JObject data = new JObject();

            data.Add("dir_firefox", txt_dir_firefox.Text);
            data.Add("dir_video", txt_dir_save_video.Text);

            File.WriteAllText("data/setting.json", data.ToString());
        }

        private void txt_dir_firefox_MouseUp(object sender, MouseEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All files (*.*)|*.exe";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txt_dir_firefox.Text = openFileDialog.FileName;
            };
        }

        private void txt_dir_save_video_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                txt_dir_save_video.Text = fbd.SelectedPath;
            }
        }
    }
}
