using LanguageManager.Common.Interfaces;
using LanguageManager.ViewModels.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LanguageManager.Views.General
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class View_Login : ContentPage, IMessage, ISubscriptions
	{
        ViewModel_Login viewModelLogin;
		public View_Login ()
		{
			InitializeComponent ();
            viewModelLogin = new ViewModel_Login();
            this.BindingContext = viewModelLogin;
            entUsername.Completed += (object sender, EventArgs e) =>
            {
                entPassword.Focus();
            };
		}
        protected override void OnAppearing()
        {
            Subscribe();
            base.OnAppearing();
        }
        protected override void OnDisappearing()
        {
            Unsubscribe();
            base.OnDisappearing();
        }
        public void ShowError(string title, string message, string close)
        {
            DisplayAlert(title, message, close);
        }

        public void Subscribe()
        {
            MessagingCenter.Subscribe<ViewModel_Login>(this, "LoginError", (sender) =>
            {
                ShowError("Login Failure", "Username or Password is invalid", "Close");
                entUsername.Text = "";
                entPassword.Text = "";
            });
        }

        public void Unsubscribe()
        {
            MessagingCenter.Unsubscribe<ViewModel_Login>(this, "LoginError");
        }
    }
}