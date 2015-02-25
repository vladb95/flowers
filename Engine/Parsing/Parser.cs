using Engine.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xNet.Net;
using xNet.Text;

namespace Engine.Parsing
{
    class Parser
    {
        Parametrs parametrs = new Parametrs();

        bool ParseIds(int page)
        {
            try
            {
                using (var request = new HttpRequest())
                {
                    request.Cookies = parametrs.Cookies;
                    request.UserAgent = HttpHelper.RandomUserAgent();
                    var response = request.Get("").ToString();
                    InfoContainer.IdList.AddRange(response.Substrings(parametrs.BeforeId, parametrs.AfterId));
                    if (!response.Contains(""))
                        return false;

                }
            }
            catch { return false; }
            ParseIds(++page);
            return true;
        }
    }
}
