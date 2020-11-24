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

namespace Controls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Person> Items { get; set; }
        public MainWindow()
        {
            Items = new ObservableCollection<Person>()
            {
                new Person(){ Name = "Aftandil", Number = "111" },
                new Person(){ Name = "Israfil", Number = "222" },
                new Person(){ Name = "Aghanatiq", Number = "333" }

            };
            InitializeComponent();
            //listBox.ItemsSource = Items;
            //comboBox.ItemsSource = Items;

            //listBox.Items.Add("Four");
        }

        //private void addButton_Click(object sender, RoutedEventArgs e)
        //{
        //    var text = textBox.Text;
        //    Items.Add(new Person() { Name = text, Number = "000"});
        //    textBox.Text = string.Empty;
        //}

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    textBlockResult.Text = textBoxText.Text;
        //    textBoxText.Text = string.Empty;
        //    MessageBox.Show("Test");
        //}
    }
}
