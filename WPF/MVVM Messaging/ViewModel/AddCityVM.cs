using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVVM_Messaging.ViewModel
{
    public class AddCityVM : ViewModelBase
    {
        public AddCityVM()
        {

        }
        private string cityName;
        public string CityName { 
            get => cityName; 
            set => Set(ref cityName, value); 
        }
        private string longitude;
        public string Longitude { 
            get => longitude; 
            set => Set(ref longitude, value); 
        }
        private string latitude;

        public string Latitude { get => latitude; set => Set(ref latitude, value); }

        private RelayCommand addCityCommand;
        public RelayCommand AddCityCommand
        {
            get
            {
                return addCityCommand ??= new RelayCommand(() =>
                {

                });
            }
        }
    }
}
