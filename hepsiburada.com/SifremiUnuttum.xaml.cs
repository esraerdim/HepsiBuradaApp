using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace hepsiburada.com
{
    /// <summary>
    /// SifremiUnuttum.xaml etkileşim mantığı
    /// </summary>
    public partial class SifremiUnuttum : Window
    {
        public SifremiUnuttum()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Uyegiris uyegiris = new Uyegiris();
            uyegiris.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }

        private void userinputmail_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(userinputmail.Text))
            {
                userinputmail.Visibility = System.Windows.Visibility.Collapsed;
                mail.Visibility = System.Windows.Visibility.Visible;
            }

        }

        private void userinputmail_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void mail_GotFocus(object sender, RoutedEventArgs e)
        {
           mail.Visibility = System.Windows.Visibility.Collapsed;
            userinputmail.Visibility = System.Windows.Visibility.Visible;
           userinputmail.Focus();

        }

        private void mail_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
