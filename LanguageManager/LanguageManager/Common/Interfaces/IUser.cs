using System;
using System.Collections.Generic;
using System.Text;

namespace LanguageManager.Common.Interfaces
{
    interface IUser
    {
        bool Login();
        bool Register(string username, string password, string email);
    }
}
