using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using MVVM_Messaging.Messages;
using MVVM_Messaging.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace MVVM_Messaging.ViewModel
{
    public class MainVM : ViewModelBase
    {
        private ViewModelBase currentView;

        public ViewModelBase CurrentView { get => currentView; set => Set(ref currentView,value); }

        public MainVM()
        {

            IMessenger messanger = App.container.GetInstance<Messenger>();
            CurrentView = App.container.GetInstance<CityListVM>();
            messanger.Register<NavigationMessage>(this, message =>
             {
                 CurrentView = message.ViewModel;
             });
        }
    }
}
