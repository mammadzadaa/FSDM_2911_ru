using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contact_App.ViewModel
{
    class StatisticsVM : ViewModelBase
    {
        private double numberOfContacts;
        private string favoriteContacts;

        public double NumberOfContacts
        {
            get => numberOfContacts;
            set => Set(ref numberOfContacts, value);
        }

        public string FavoriteContacts { 
            get => favoriteContacts; 
            set => Set(ref favoriteContacts, value); }
    }
}
