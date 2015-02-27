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
                    var response = request.Get(parametrs.GetUrl()).ToString();
                    if (!response.Contains("Результаты поиска"))
                        return false;
                    InfoContainer.IdList.AddRange(response.Substrings(parametrs.BeforeId, parametrs.AfterId));
                }
            }
            catch { return false; }
            ParseIds(++page);
            return true;
        }
    }
}
