using GalaSoft.MvvmLight.Messaging;
using MVVM_Messaging.Messages;
using MVVM_Messaging.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MVVM_Messaging.View
{
    /// <summary>
    /// Interaction logic for AddCityUC.xaml
    /// </summary>
    public partial class AddCityUC : UserControl
    {
        public AddCityUC()
        {
            InitializeComponent();
        }

        private void Map_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            var location = Map.ViewportPointToLocation(e.GetPosition(Map));

            App.container.GetInstance<Messenger>().Send(new LocationMessage()
            {
                Latitude = location.Latitude,
                Longitude = location.Longitude
            });

            //if(DataContext is AddCityVM vm)
            //{
            //    vm.Latitude = location.Latitude.ToString();
            //    vm.Longitude = location.Longitude.ToString();
            //}

        }
    }
}
