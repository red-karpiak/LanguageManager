using LanguageManager.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LanguageManager.Common
{
    public class User : IUser
    {
        public string Username { get; set; }
        public string Password { get; set; }


        public User(string name, string pass)
        {
            Username = name;
            Password = pass;
        }
        public bool Login()
        {
            return (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password)) ? false : true;
        }

        public bool Register(string username, string password, string email)
        {
            throw new NotImplementedException();
        }
    }
}
