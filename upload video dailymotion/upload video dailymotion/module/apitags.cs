using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upload_video_dailymotion.module
{
    class apitags
    {
        public static string tags(string title)
        {
            string tags = "";

            rp http = new rp();

            http.get("https://rapidtags.io/api/generator?query="+ Uri.EscapeUriString(title) +"&type=YouTube");
            if (http.response != null)
            {
                JObject data = JObject.Parse(http.response);
                tags = String.Join(", ", data["tags"].ToArray().ToList());
            };

            return tags;
        }
    }
}
