using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using MVVM_Messaging.Messages;
using MVVM_Messaging.Model;
using MVVM_Messaging.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace MVVM_Messaging.ViewModel
{
    public class CityListVM : ViewModelBase
    {
        private ICityStorage cityStorage;
        public IEnumerable<Forecast> Cities
        {
            get
            {
                return cityStorage.GetCities();
            }
        }
        private string temp = "10";

        public string Temp { get => temp; set => Set(ref temp, value); }
        private string cityName = "Baku";

        public string CityName { get => cityName; set => Set(ref cityName, value); }

        private RelayCommand addCity;

        private RelayCommand doubleClickCommand;
        public RelayCommand DoubleClickCommand => doubleClickCommand ??= new RelayCommand(() =>
            
                {
                    messanger.Send(new NavigationMessage() { ViewModel = App.container.GetInstance<CityInfoVM>() });
                    messanger.Send(new ForecastMessage() { Forecast = SelectedWeatherItem });
                }
             );


        private IMessenger messanger;
        public CityListVM()
        {
            messanger = App.container.GetInstance<Messenger>();
            cityStorage = App.container.GetInstance<LocalCityStorage>();
        }

        public RelayCommand AddCity => addCity ??= new RelayCommand(() =>
        {
            messanger.Send(new NavigationMessage() { ViewModel = App.container.GetInstance<AddCityVM>() });
        });
        public Forecast SelectedWeatherItem
        {
            get => selectedWeatherItem; 
            set
            {
                Set(ref selectedWeatherItem, value);
                ViewCity.RaiseCanExecuteChanged();
            }
        }
        private RelayCommand viewCity;
        private Forecast selectedWeatherItem;

        public RelayCommand ViewCity => viewCity ??= new RelayCommand(() =>
        {
            messanger.Send(new NavigationMessage() { ViewModel = App.container.GetInstance<CityInfoVM>() });
            messanger.Send(new ForecastMessage() { Forecast = SelectedWeatherItem });
        }, () =>
        {
            return SelectedWeatherItem != null;
        });
    }
}
