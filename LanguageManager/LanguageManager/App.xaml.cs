using LanguageManager.Common;
using LanguageManager.Services;
using LanguageManager.Views.General;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace LanguageManager
{
	public partial class App : Application
	{
        public static bool LoggedIn = false;
        public static RestService restService;

        public static User LoggedInUser { get; set; } //temporary until database is functional, just for UI testing

        public App ()
		{
			InitializeComponent();

			MainPage = new View_Login();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
