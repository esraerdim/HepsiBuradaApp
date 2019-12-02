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
    /// UrunArama.xaml etkileşim mantığı
    /// </summary>
    public partial class UrunArama : Window
    {
        public UrunArama()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(userinput.Text))
            {
                userinput.Visibility = System.Windows.Visibility.Collapsed;
                arama.Visibility = System.Windows.Visibility.Visible;
              userinput.Focus();
            }
        }

        private void arama_GotFocus(object sender, RoutedEventArgs e)
        {
            arama.Visibility = System.Windows.Visibility.Collapsed;
            userinput.Visibility = System.Windows.Visibility.Visible;
        }

        private void arama_TextChanged(object sender, TextChangedEventArgs e)
        {
            

        }
      
        private void userinput_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Kategoriler kategoriler = new Kategoriler();
            kategoriler.Show();
            this.Hide();
        }
       

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
                if (userinput.Text == "Persil"||userinput.Text=="persil")
                {
                    UrunaramaPersil urunaramaPersil = new UrunaramaPersil();
                    urunaramaPersil.Show();
                    this.Hide();
                arama1.Text = userinput.Text;
                    
             
                 }
                else if (userinput.Text == "telefon"||userinput.Text=="Telefon")
                {
                    urunaramatelefon urunaramatelefon = new urunaramatelefon();
                    urunaramatelefon.Show();
                    this.Hide();
                    arama2.Text = userinput.Text;
                    



            }
                else if (userinput.Text == "televizyon"||userinput.Text=="Televizyon")
                {
                    urunaramatelevizyon urunaramatelevizyon = new urunaramatelevizyon();
                    urunaramatelevizyon.Show();
                    this.Hide();
                    arama3.Text = userinput.Text;
                    



            }

        
                else
                {
                    Boylebirurunbulunamadı boylebirurunbulunamadı = new Boylebirurunbulunamadı();
                    boylebirurunbulunamadı.Show();
                    this.Hide();
                 boylebirurunbulunamadı.bulunamadı.Text =userinput.Text;
                    arama1.Text = userinput.Text;
                    


            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            arama1.Text = "";
            arama2.Text = "";
            arama3.Text = "";
        }

        private void arama1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }

  
            

       
    }
    
  

