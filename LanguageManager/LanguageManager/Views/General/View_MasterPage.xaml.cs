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
	public partial class View_MasterPage : ContentPage, ISubscriptions
	{
        ViewModel_MasterPage viewModel;
        public View_MasterPage ()
		{
			InitializeComponent ();
            viewModel = new ViewModel_MasterPage();
            this.BindingContext = viewModel;
		}

        public void Subscribe()
        {
            //subscribe to Commands so that the View Model can interact with the View
            MessagingCenter.Subscribe<ViewModel_MasterPage, Common.MenuItem>(this, "OnItemSelected", (sender, selectedItem) =>
            {
                var item = selectedItem as Common.MenuItem;
                ((MasterDetailPage)Application.Current.MainPage).Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                //determines whether or not the menu hides after selection (false = hide)
                ((MasterDetailPage)Application.Current.MainPage).IsPresented = false;
                lvContent.SelectedItem = null;
            });
        }

        public void Unsubscribe()
        {
            //Unsubscribe from commands
            MessagingCenter.Unsubscribe<ViewModel_MasterPage, Common.MenuItem>(this, "OnItemSelected");
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
    }
}