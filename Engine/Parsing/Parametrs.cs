using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xNet.Net;

namespace Engine.Parsing
{
    class Parametrs
    {
        public bool SearcherIsMale { get; set; } 
        public string Country { get; set; }
        public int UpAge { get; set; }
        public int DownAge { get; set; }
        public bool Online { get; set; }
        public string BeforeId { get; set; }
        public string AfterId { get; set; }
        public CookieDictionary Cookies { get; set; }

        public string GetUrl(int page)
        {

            string url = "http://www.maybe.ru/display.php?process=1&gend=" + (SearcherIsMale ? 1 : 0).ToString() +
                "&seek=wl&city=204&country=1001&place=5&agemin=" + DownAge +
                "&agemax=" + UpAge +
                "&zod=0&family=0&body=0&hmin=110&hmax=230&prefs=0&expen=0" +
                "&onon=" + (Online ? 1 : 0).ToString() +
                "&pg=" + page;
            return url;
        }
    }
}
