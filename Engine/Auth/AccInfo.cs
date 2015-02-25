using xNet.Net;

namespace Engine.Auth
{
    class AccInfo
    {
        public string Login { get; set; }
        public string Pass { get; set; }
        public bool AuthInfo { get; set; }
        public CookieDictionary Cookies { get; set; }
    }
}
