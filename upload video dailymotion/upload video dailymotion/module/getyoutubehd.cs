using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace upload_video_dailymotion.module
{
    class getyoutubehd
    {
        bool is_download = true;
        public JObject get(string videoid)
        {
            JObject data = new JObject();
            rp http = new rp();

            http.get("http://tube.jopen.me/api/ytb/dl/" + videoid);
            if (http.response != null)
                data = JObject.Parse(http.response);

            return data;
        }

        public bool download_video(string file_url, string filename)
        {
            using (WebClient client = new WebClient())
            {
                client.DownloadFileAsync(new Uri(file_url), filename);
                client.DownloadFileCompleted += DownloadCompleted;
                is_download = true;
            };

            while(is_download)
            {
                Thread.Sleep(1000);
            };

            return true;
        }

        private void DownloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            is_download = false;
        }
    }
}
