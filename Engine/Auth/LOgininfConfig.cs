using System;
using System.Collections.Generic;

namespace Engine.Auth
{
    internal class LogininfConfig
    {
        readonly List<AccInfo> _accountList =new List<AccInfo>();

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

        public List<AccInfo> GetAccountList
        {
            get
            {
                BadRemover();
                return _accountList;
            }
        }

        void BadRemover()
        {
            try
            {
                for (var i = 0; i < _accountList.Count; i++)
                {
                    if (!_accountList[i].AuthInfo)
                    {
                        _accountList.RemoveAt(i);
                    }
                }
            }
            catch { }
        }
    }
}
