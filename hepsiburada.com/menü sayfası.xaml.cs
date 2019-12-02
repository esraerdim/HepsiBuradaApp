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
    /// menü_sayfası.xaml etkileşim mantığı
    /// </summary>
    public partial class menü_sayfası : Window
    {
        public menü_sayfası()
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

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Uyegiris uyegiris = new Uyegiris();
            uyegiris.Show();
            this.Hide();
            //TODO: LOGİN OLUNMUŞ MU
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Uyegiris uyegiris = new Uyegiris();
            uyegiris.Show();
            this.Hide();
            //TODO: LOGİN OLUNMUŞ MU
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Sepetim sepetim = new Sepetim();
            sepetim.Show();
            this.Hide();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Uyegiris uyegiris = new Uyegiris();
            uyegiris.Show();
            this.Hide();
            //TODO: LOGİN OLUNMUŞ MU
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            BildirimMerkezi bildirimMerkezi = new BildirimMerkezi();
            bildirimMerkezi.Show();
            this.Hide();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            KarşılaştırmaListem karşılaştırmaListem = new KarşılaştırmaListem();
            karşılaştırmaListem.Show();
            this.Hide();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Uyegiris uyegiris = new Uyegiris();
            uyegiris.Show();
            this.Hide();
            //TODO: LOGİN OLUNMUŞ MU
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            MusteriHizmetleri musteriHizmetleri = new MusteriHizmetleri();
            musteriHizmetleri.Show();
            this.Hide();
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            GeriBildirim geriBildirim = new GeriBildirim();
            geriBildirim.Show();
            this.Hide();
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            ayarlar ayarlar = new ayarlar();
            ayarlar.Show();
            this.Hide();
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }
    }
}
