using Contact_App.Model;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contact_App.ViewModel
{
    class ContactListVM : ViewModelBase
    {
        private string text;

        public List<Contact> Contacts { get; set; } = new List<Contact>();

        public string Text { get => text; set => Set(ref text, value); }

        public ContactListVM()
        {
            Contacts.Add(new Contact()
            {
                Name = "Aftandil",
                Number = "09932131",
                Position = "Boss",
                Favorite = true
            });
            Contacts.Add(new Contact()
            {
                Name = "Israfil",
                Number = "09932343131",
                Position = "employee",
                Favorite = false
            });
            Contacts.Add(new Contact()
            {
                Name = "Gulchohre",
                Number = "09342432",
                Position = "employee",
                Favorite = true
            });
        }
    }
}
