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
    /// Uyegiris.xaml etkileşim mantığı
    /// </summary>
   
    public partial class Uyegiris : Window
    {
        public Uyegiris()
        {
            InitializeComponent();
        }
       
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        } 

        private void sifretext_GotFocus(object sender, RoutedEventArgs e)
        {
            sifretext.Visibility = System.Windows.Visibility.Collapsed;
            userinputsifretext.Visibility = System.Windows.Visibility.Visible;
        }

        private void userinputsifretext_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(userinputsifretext.Text))
            {
                userinputsifretext.Visibility = System.Windows.Visibility.Collapsed;
                sifretext.Visibility = System.Windows.Visibility.Visible;
                userinputsifretext.Focus();
            }

        }

        private void sifretext_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void usirinputemailtext_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(usirinputemailtext.Text))
            {
                usirinputemailtext.Visibility = System.Windows.Visibility.Collapsed;
                emailtext.Visibility = System.Windows.Visibility.Visible;
            }

        }

        private void emailtext_GotFocus(object sender, RoutedEventArgs e)
        {
            emailtext.Visibility = System.Windows.Visibility.Collapsed;
            usirinputemailtext.Visibility = System.Windows.Visibility.Visible;
            usirinputemailtext.Focus();
        }

        private void emailtext_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Window_ManipulationStarted(object sender, ManipulationStartedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }

        private void ___Ad_yok_email_text_Click(object sender, RoutedEventArgs e)
        {
            SifremiUnuttum sifremiUnuttum = new SifremiUnuttum();
            sifremiUnuttum.Show();
            this.Hide();
        }

        private void Button_Click_enter(object sender, RoutedEventArgs e)
        {
            uyegiriskontrol uyegiriskontrol = new uyegiriskontrol();
            string a = Convert.ToString(usirinputemailtext);
            string b = Convert.ToString(userinputsifretext);
            
            
            if (uyegiriskontrol.login(a,b) == true)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Hide();
            }
            else if(uyegiriskontrol.login(a,b)==false)
            {
                MessageBox.Show("hatalı bir email ya da sifre girdiniz lütfen tekrar kontrol edin ya da üye olun.");
               
            }
            
        }
    }
}
