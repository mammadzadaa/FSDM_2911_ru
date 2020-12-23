using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contact_App.ViewModel
{
    class StatisticsVM : ViewModelBase
    {
        private string numberOfContacts;
        private string favoriteContacts;

        public string NumberOfContacts
        {
            get => numberOfContacts;
            set => Set(ref numberOfContacts, value);
        }

        public string FavoriteContacts { 
            get => favoriteContacts; 
            set => Set(ref favoriteContacts, value); }
    }
}
