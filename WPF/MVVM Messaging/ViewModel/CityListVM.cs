using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using MVVM_Messaging.Messages;
using MVVM_Messaging.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace MVVM_Messaging.ViewModel
{
    public class CityListVM : ViewModelBase
    {
        private string temp = "10";

        public string Temp { get => temp; set => Set(ref temp, value); }
        private string cityName = "Baku";

        public string CityName { get => cityName; set => Set(ref cityName, value); }

        private RelayCommand addCity;
        private IMessenger messanger;
        public CityListVM()
        {
            this.messanger = App.container.GetInstance<Messenger>();
        }

        public RelayCommand AddCity => addCity ??= new RelayCommand(() =>
        {
            messanger.Send(new NavigationMessage() { ViewModel = new AddCityVM() }) ;
        });
    }
}
