using GalaSoft.MvvmLight.Messaging;
using MVVM_Messaging.Services;
using MVVM_Messaging.ViewModel;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MVVM_Messaging
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Container container;

        protected override void OnStartup(StartupEventArgs e)
        {
            container = new Container();
            Register();

            var main = container.GetInstance<MainWindow>();
            main.Show();

            base.OnStartup(e);
        }  
        
        private void Register()
        {
            container.RegisterSingleton<CityListVM>();
            container.RegisterSingleton<AddCityVM>();
            container.RegisterSingleton<CityInfoVM>();

            container.RegisterSingleton<MainVM>();
            container.RegisterSingleton<MainWindow>();
            container.RegisterSingleton<Messenger>();
            container.RegisterSingleton<DefaultWeatherAPIService>();
            container.RegisterSingleton<LocalCityStorage>();
            container.Verify();
        }
    }
}
