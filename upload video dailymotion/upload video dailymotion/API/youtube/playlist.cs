using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upload_video_dailymotion.API.youtube
{
    class playlist
    {
        public JObject video(string playlist, string next_token = "")
        {
            JObject data = new JObject();

            string urlAPI = "https://www.googleapis.com/youtube/v3/playlistItems?key=AIzaSyBGfPJGxeDatq3_DzE5D8WUieCkWTKuP84&part=snippet&maxResults=50&playlistId="+ playlist;

            rp http = new rp();

            http.get(urlAPI);

            if (http.response != null)
            {
                data = JObject.Parse(http.response);
            };

            return data;
        }
    }
}
