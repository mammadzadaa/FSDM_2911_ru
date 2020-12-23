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

namespace Contact_App.Controls
{
    /// <summary>
    /// Interaction logic for DashboardTile.xaml
    /// </summary>
    public partial class DashboardTile : UserControl
    {


        public string Header
        {
            get => GetValue(HeaderProperty) as string;
            set => SetValue(HeaderProperty, value);
        }

        public static readonly DependencyProperty HeaderProperty = DependencyProperty.Register(
            nameof(Header),
            typeof(string),
            typeof(DashboardTile),
            new FrameworkPropertyMetadata("",FrameworkPropertyMetadataOptions.BindsTwoWayByDefault)
            );

        public string Value {
            get => GetValue(ValueProperty) as string;
            set => SetValue(ValueProperty, value);
        }

        public static readonly DependencyProperty ValueProperty = DependencyProperty.Register(
          nameof(Value),
          typeof(string),
          typeof(DashboardTile),
          new FrameworkPropertyMetadata("", FrameworkPropertyMetadataOptions.BindsTwoWayByDefault)
          );

        public DashboardTile()
        {
            InitializeComponent();
        }
    }
}
