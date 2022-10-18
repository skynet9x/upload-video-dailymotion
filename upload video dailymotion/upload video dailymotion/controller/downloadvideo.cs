using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using upload_video_dailymotion.module;

namespace upload_video_dailymotion.controller
{
    class downloadvideo
    {
        public string download(string video)
        {
            getyoutubehd API = new getyoutubehd();

            JObject data = API.get(video);
            if (data["url"] != null)
            {
                string urlFile = data["url"][1]["url"].ToString();
                //string filename = Global.config["dir_video"].ToString() + "/" + data["meta"]["title"].ToString() + ".mp4";
                string filename = Global.config["dir_video"].ToString() + "\\" + Global.RandomString(24) + ".mp4";
                API.download_video(urlFile, filename);

                return filename;
            };

            return null;
        }
    }
}
