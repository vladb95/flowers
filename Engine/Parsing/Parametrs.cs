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
        public string Sex { get; set; }
        public string Country { get; set; }
        public int UpAge { get; set; }
        public int DownAge { get; set; }
        public bool Online { get; set; }
        public string BeforeId { get; set; }
        public string AfterId { get; set; }
        public CookieDictionary Cookies { get; set; }

        public string GetUrl()
        {
            string url;
            return url;
        }
    }
}
