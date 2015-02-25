using System;
using System.Collections.Generic;

namespace Engine.Auth
{
    internal class LogininfConfig
    {
        List<AccInfo> _accountList =new List<AccInfo>();

        public void AddAccount(string login, string pass)
        {
            try
            {
                var info = new Auth()
                {
                    Login = login,
                    Pass = pass
                }.GetInfo;

                _accountList.Add(info);
            }
            catch { }
        }
    }
}
