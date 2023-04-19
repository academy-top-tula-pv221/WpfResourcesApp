using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WpfResourcesApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //List<string> users = new();
            //users.Add("Bob");
            //users.Add("Joe");
            //users.Add("Sam");
            //users.Add("Tim");

            //this.Resources.Add("users", users);

            InitializeComponent();

            btnHello.Content = AppLang.Greeting;
            btnBy.Content = AppLang.Farewell;

            //SolidColorBrush clBrushAqua = new(Colors.Aqua);
            //this.Resources.Add("clBrushWhite", clBrushAqua);

            ////txtBox.Foreground = (Brush)this.TryFindResource("clBrushWhite");
            //txtBox.SetResourceReference(TextBox.ForegroundProperty, "clBrushWhite");



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["clrBrushRed"] = new SolidColorBrush(Colors.DarkBlue);
            this.Resources["clBrushWhite"] = new SolidColorBrush(Colors.Yellow);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("OK Button Click");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            UpdateContent();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ru");
            UpdateContent();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fr");
            UpdateContent();
        }

        private void UpdateContent()
        {
            btnHello.Content = AppLang.Greeting;
            btnBy.Content = AppLang.Farewell;
        }
    }
}
