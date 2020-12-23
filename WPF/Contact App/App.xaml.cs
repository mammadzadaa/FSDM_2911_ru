using Contact_App.ViewModel;
using SimpleInjector;
using System;
using System.Collections.Generic;

using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Contact_App
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
       public static Container container = new Container();

        protected override void OnStartup(StartupEventArgs e)
        {
            container.Register<StatisticsVM>();
            container.Register<ContactListVM>();
            container.Register<AddContactVM>();
            container.Register<MainVM>();
            container.Verify();
            base.OnStartup(e);
        }
    }

        
}
