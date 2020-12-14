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

            container.Register<CityListVM>();
            container.Register<AddCityVM>();
            container.Register<CityInfoVM>();

            container.RegisterSingleton<MainVM>();
            container.Register<MainWindow>();
            container.RegisterSingleton<Messenger>();

            container.Verify();

            var main = container.GetInstance<MainWindow>();
            main.Show();

            base.OnStartup(e);
        }        
    }
}
