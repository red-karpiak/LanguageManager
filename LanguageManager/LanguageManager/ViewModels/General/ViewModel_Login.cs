using LanguageManager.Common;
using LanguageManager.Services;
using LanguageManager.Views.General;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace LanguageManager.ViewModels.General
{
    public class ViewModel_Login
    {
        public ICommand Login { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public ViewModel_Login()
        {
            Login = new Command(OnLogin);

        }
        private void OnLogin()
        {
            
            User user = new User(Username, Password);
            if (user.Login())
            {
                App.LoggedInUser = user;
                App.restService = new RestService();
                App.LoggedIn = true;

                if (Device.RuntimePlatform == Device.Android)
                {
                    Application.Current.MainPage = new View_MasterDetail();
                }
            }
            else
            {
                MessagingCenter.Send(this, "LoginError");
                //send errors to the user
                //invalid?
                //no user exists?
            }

        }
        private void OnRegister()
        {

        }
    }
}
