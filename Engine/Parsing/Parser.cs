using Engine.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    request.Cookies = cookies;
                    request.UserAgent = HttpHelper.RandomUserAgent();
                    var response = request.Get("").ToString();
                    int id = response.Substrings(parametrs.BeforeId, parametrs.AfterId);
                    InfoContainer.IdList.Add(id);
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
