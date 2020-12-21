using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.Maps.MapControl.WPF;
using MVVM_Messaging.Messages;
using MVVM_Messaging.Model;
using MVVM_Messaging.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Windows;

namespace MVVM_Messaging.ViewModel
{
    public class AddCityVM : ViewModelBase, IDataErrorInfo
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
        [Required]
        public string CityName { 
            get => cityName;
            set
            {
                Set(ref cityName, value);
                AddCityCommand.RaiseCanExecuteChanged();
            }
        }
        private string longitude;
        public string Longitude { 
            get => longitude;
            set
            { 
                Set(ref longitude, value);
                if (!string.IsNullOrWhiteSpace(Latitude) && double.TryParse(Latitude, out double lat) && double.TryParse(Longitude, out double lon))
                {
                    Location = new Location(lat, lon);
                }
                AddCityCommand.RaiseCanExecuteChanged();
            }

        }
        private string latitude;

        public string Latitude 
        { 
            get => latitude;
            set 
            { 
                Set(ref latitude, value);
                if (!string.IsNullOrWhiteSpace(Longitude) && double.TryParse(Latitude, out double lat) && double.TryParse(Longitude, out double lon))
                {
                    Location = new Location(lat, lon);
                }
                AddCityCommand.RaiseCanExecuteChanged();
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
                AddCityCommand.RaiseCanExecuteChanged();
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
                AddCityCommand.RaiseCanExecuteChanged();
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
                }, () => {
                    if (IsCityRBChecked && !string.IsNullOrWhiteSpace(CityName))
                    {
                        return true;
                    }
                    if (IsCityCoordsRBChecked && double.TryParse(Latitude, out double _) && double.TryParse(Longitude, out double __))
                    {
                        return true;
                    }
                    return false;
                });
            }
        }

        public string Error { get; }
        public string this[string columnName]
        {
            get
            {
                var context = new ValidationContext(this);
                var results = new List<ValidationResult>();
                var isValid = Validator.TryValidateObject(this, context, results, true);

                if (isValid)
                {
                    return string.Empty;
                }

                var result = results.FirstOrDefault(x => x.MemberNames.Contains(columnName));

                if (result is null)
                {
                    return string.Empty;
                }
                return result.ErrorMessage;
            }
        }
    }
}
