using System;
using System.Collections.Generic;
using System.Linq;
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
using System.Windows.Forms;
using System.Data;
using System.IO;



namespace hepsiburada.com
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public int count;
        public MainWindow()
        {
            InitializeComponent();

        }















        private void Button_Click(object sender, RoutedEventArgs e)
        {
            menü_sayfası menü_Sayfası = new menü_sayfası();
            menü_Sayfası.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {


        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {






        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            UrunArama urunArama = new UrunArama();
            urunArama.Show();
            this.Hide();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Kategoriler kategoriler = new Kategoriler();
            kategoriler.Show();
            this.Hide();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            UrunArama urunArama = new UrunArama();
            urunArama.Show();
            this.Hide();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            HepsiModa hepsiModa = new HepsiModa();
            hepsiModa.Show();
            this.Hide();
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            EviniYenile eviniYenile = new EviniYenile();
            eviniYenile.Show();
            this.Hide();
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            Kampanya kampanya = new Kampanya();
            kampanya.Show();
            this.Hide();
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            Oneriler oneriler = new Oneriler();
            oneriler.Show();
            this.Hide();
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            Telefon telefon = new Telefon();
            telefon.Show();
            this.Hide();
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            Televizyon televizyon = new Televizyon();
            televizyon.Show();
            this.Hide();
        }


        









    
        private void Button_Click_21(object sender, RoutedEventArgs e)
        {
            xiamoindirim xiamoindirim = new xiamoindirim();
            xiamoindirim.Show();
            this.Hide();
        }

        

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            persil1 persil = new persil1();
            persil.Show();
            this.Hide();
        }

        private void Button_Click_20(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            persil1 persil1 = new persil1();
            persil1.Show();
            this.Hide();
        }
    }
}
    



