using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Styles
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Image> Images { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Images = new ObservableCollection<Image>()
            {
                new Image
                {
                    Photo = "Images/Cat.png",
                    Title = "Cat"                    
                },
                new Image
                {
                    Photo = "Images/space.jpg",
                    Title = "Space"
                }

            };
            imageListBox.ItemsSource = Images;
            //tb.Background = new SolidColorBrush(Color.FromRgb(255,255,0));
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    CommonOpenFileDialog dialog = new CommonOpenFileDialog();
        //    dialog.InitialDirectory = "C:\\Users";
        //    dialog.IsFolderPicker = true;
        //    if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
        //    {
        //        MessageBox.Show("Selected folder: " + dialog.FileName);
        //    }

        //    //if (midRow.Height.Value == 0)
        //    //{
        //    //    midRow.Height = new GridLength(100);

        //    //}
        //    //else
        //    //{
        //    //    midRow.Height = new GridLength(0);
        //    //}
        //}

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    if (textBlock.IsVisible)
        //    {
        //        textBlock.Visibility = Visibility.Collapsed;
        //    }
        //    else
        //    {
        //        textBlock.Visibility = Visibility.Visible;
        //    }
        //}

        public class Image
        {
            public string Photo { get; set; }
            public string Title { get; set; }
        }
    }
}
