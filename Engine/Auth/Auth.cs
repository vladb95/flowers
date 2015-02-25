using xNet.Net;

namespace Engine.Auth
{
    internal class Auth
    {
        CookieDictionary _cookie=new CookieDictionary();

        public AccInfo GetInfo
        {
            get
            {
                return new AccInfo
                {
                    Login = Login,
                    Pass = Pass,
                    AuthInfo = AuthFlag,
                    Cookies = Cookies
                };
            }
        }

        public CookieDictionary Cookies
        {
            get { return _cookie; }
        }

        public string Login { get; set; }
        public string Pass { get; set; }

        public bool AuthFlag { get { return Checker(); } }

        bool Checker()
        {
            try
            {
                using (var request = new HttpRequest())
                {
                    request.Cookies = _cookie;
                    request.UserAgent = HttpHelper.RandomUserAgent();
                    var responce = request.Post("", "").ToString();
                    _cookie = request.Cookies;
                    return responce.Contains("");
                }
            }
            catch { }
            return false;
        }
    }
}
