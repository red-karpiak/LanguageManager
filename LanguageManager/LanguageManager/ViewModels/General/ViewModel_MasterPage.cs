using LanguageManager.Common;
using LanguageManager.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace LanguageManager.ViewModels.General
{
    public class ViewModel_MasterPage : IMenu, INotifyPropertyChanged
    {
        public List<Common.MenuItem> Items { get; set; }
        public ICommand LogoutCommand { get; set; } //implement later
        private Common.MenuItem selectedItem;

        public event PropertyChangedEventHandler PropertyChanged;

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
                // new Common.MenuItem("Home", )
            };
        }
    }
}

