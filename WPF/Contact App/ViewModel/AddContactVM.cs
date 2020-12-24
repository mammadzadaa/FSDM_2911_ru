using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Contact_App.ViewModel
{

    public class AddContactVM : ViewModelBase
    {
        private string name;
        private string phone;
        private string email;
        private string bio;
        private string photoUrl;
        public string Name { get => name; set => Set(ref name, value); }
        public string Phone { get => phone; set => Set(ref phone, value); }
        public string Email { get => email; set => Set(ref email, value); }
        public string Bio { get => bio; set => Set(ref bio, value); }
        public string PhotoUrl { get => photoUrl; set => Set(ref photoUrl, value); }
    }
}
