using Contact_App.Model;
using Contact_App.Services;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contact_App.ViewModel
{
    class ContactListVM : ViewModelBase
    {
        private string text;
        public IUserDataReader DataReader { get; }
        public IEnumerable<Contact> Contacts { get; set; }

        public string Text {
            get => text;
            set => Set(ref text, value);
        }

        public ContactListVM()
        {
            DataReader = new UserDataReader();
            Contacts = DataReader.Read("Contacts.json");
        }
    }
}
