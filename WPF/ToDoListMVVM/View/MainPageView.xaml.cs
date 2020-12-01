using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ToDoListMVVM.Model;
using ToDoListMVVM.ViewModel;

namespace ToDoListMVVM.View
{
    /// <summary>
    /// Interaction logic for MainPageView.xaml
    /// </summary>
    public partial class MainPageView : Window
    {
        public MainPageView()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }       
    }
}
