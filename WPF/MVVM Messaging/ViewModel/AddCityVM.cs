using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.Maps.MapControl.WPF;
using MVVM_Messaging.Messages;
using MVVM_Messaging.Model;
using MVVM_Messaging.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace MVVM_Messaging.ViewModel
{
    public class AddCityVM : ViewModelBase
    {
        public AddCityVM()
        {
            weatherAPIService = App.container.GetInstance<DefaultWeatherAPIService>();
            cityStorage = App.container.GetInstance<LocalCityStorage>();
            messenger = App.container.GetInstance<Messenger>();

            messenger.Register<LocationMessage>(this, x =>
            {
                Longitude = x.Longitude.ToString();
                Latitude = x.Latitude.ToString();
            });
        }
        private IWeatherAPIService weatherAPIService;
        private ICityStorage cityStorage;
        private IMessenger messenger;
        private string cityName;
        public string CityName { 
            get => cityName; 
            set => Set(ref cityName, value); 
        }
        private string longitude;
        public string Longitude { 
            get => longitude;
            set
            { 
                Set(ref longitude, value);
                if (!string.IsNullOrWhiteSpace(Latitude))
                {
                    Location = new Location(double.Parse(Latitude),double.Parse(Longitude));
                }
            }

        }
        private string latitude;

        public string Latitude 
        { 
            get => latitude;
            set 
            { 
                Set(ref latitude, value);
                if (!string.IsNullOrWhiteSpace(Longitude))
                {
                    Location = new Location(double.Parse(Latitude), double.Parse(Longitude));
                }
            }
        }
        private bool isCityCoordsRBChecked;
        public bool IsCityCoordsRBChecked
        {
            get
            {
                return isCityCoordsRBChecked;
            }
            set
            {
                Set(ref isCityCoordsRBChecked, value);
            }
        }
        private bool isCityRBChecked = true;
        public bool IsCityRBChecked
        {
            get
            {
                return isCityRBChecked;
            }
            set
            {
                Set(ref isCityRBChecked, value);
            }
        }
        private RelayCommand cancelCommand;
        public RelayCommand CancelCommand => cancelCommand ??= new RelayCommand(() =>
        {
            messenger.Send(new NavigationMessage()
            {
                ViewModel = App.container.GetInstance<CityListVM>()
            });
        });
        private Location location = new Location(42,51);
        public Location Location
        {
            get
            {
                return location;
            }
            set
            {
                Set(ref location, value);
            }
        }

        private RelayCommand addCityCommand;
        public RelayCommand AddCityCommand
        {
            get
            {
                return addCityCommand ??= new RelayCommand(() =>
                {
                    Forecast result = null;
                    if (IsCityRBChecked)
                    {
                        result = weatherAPIService.GetForecast(CityName);
                    }
                    if (IsCityCoordsRBChecked)
                    {
                        if (float.TryParse(Latitude, out float lat) && float.TryParse(Longitude, out float lon))
                        {
                            result = weatherAPIService.GetForecast(lat, lon);
                        }
                    }
                    if (result != null)
                    {
                        cityStorage.AddCity(result);
                        messenger.Send(new NavigationMessage() { ViewModel = App.container.GetInstance<CityListVM>() });
                    }
                });
            }
        }
    }
}
