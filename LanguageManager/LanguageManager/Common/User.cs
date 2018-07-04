using LanguageManager.Common.Interfaces;
using LanguageManager.DataManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace LanguageManager.Common
{
    public class User : DataEntry, IUser
    {
        public string Username { get; set; }
        public string Password { get; set; }
        
        public User(int id, string name, string pass) : base(id)
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
