using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contact_App.ViewModel
{
    class MainVM : ViewModelBase
    {
        private ViewModelBase currentViewModel;

        public ViewModelBase CurrentViewModel { get => currentViewModel; set => Set(ref currentViewModel, value); }
        public MainVM()
        {
            CurrentViewModel = new ContactListVM();
        }
        private RelayCommand addContactCommand;
        public RelayCommand AddContactCommand => addContactCommand ??= new RelayCommand(() =>
        {
            CurrentViewModel = new AddContactVM();
        });
    }  
}
