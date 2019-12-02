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
    /// Boylebirurunbulunamadı.xaml etkileşim mantığı
    /// </summary>
    public partial class Boylebirurunbulunamadı : Window
    { 
        public Boylebirurunbulunamadı()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Kategoriler kategoriler = new Kategoriler();
            kategoriler.Show();
            this.Hide();
        }
    }
}
