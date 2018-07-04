using LanguageManager.Common;
using LanguageManager.Common.Interfaces;
using LanguageManager.Views.Detail;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace LanguageManager.ViewModels.General
{
    public class ViewModel_MasterPage : IMenu
    {
        public List<Common.MenuItem> Items { get; set; }
        public ICommand LogoutCommand { get; set; } //implement later
        private Common.MenuItem selectedItem;

        public ViewModel_MasterPage()
        {
            SetItems();
            LogoutCommand = new Command(OnLogout);
        }
        public Common.MenuItem SelectedItem
        {
            get { return selectedItem; }
            set
            {
                if (selectedItem != value)
                {
                    selectedItem = value;
                    MessagingCenter.Send(this, "OnItemSelected", selectedItem);
                }
            }
        }
        public void SetItems()
        {
            Items = new List<Common.MenuItem>
            {
                new Common.MenuItem("Home", typeof(View_Home)),
                new Common.MenuItem("Progress", typeof(View_Progress)),
                new Common.MenuItem("Characters", typeof(View_Characters)),
                new Common.MenuItem("Words", typeof(View_Words)),
                new Common.MenuItem("Phrases", typeof(View_Phrases)),
                new Common.MenuItem("Tests", typeof(View_Tests)),
                new Common.MenuItem("Settings", typeof(View_Settings))
            };
        }
        public void OnLogout()
        {
            //implement later
        }
    }
}

