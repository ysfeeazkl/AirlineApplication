using Hava_Yolu_Uygulaması.Sınıflar;
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

namespace Hava_Yolu_Uygulaması.Sayfalar
{
    /// <summary>
    /// Interaction logic for AdminSayfası.xaml
    /// </summary>
    public partial class AdminSayfası : Page
    {
        Admin adm;
        List<string> Karakterler = new List<string>() { "a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z","A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z","0","1","2","3","4","5","6","7","8","9"};
        int Ü1, Ü2, Ü3, Ü4, Ü5,Ü6;
        Random rdn = new Random();
        string HataMesajı;
        public AdminSayfası()
        {
            InitializeComponent();
            
            BtnÜret.Click += BtnÜret_Click;
            BtnAdminGirişi.Click += BtnAdminGirişi_Click;

            RandomGüvenlikNumarasıÜret();

            TbToplamAdminSayısı.Text = Veri.Adminler.Count.ToString();
            TxtNickname.ItemsSource = Veri.Adminler;
        }

        private void BtnAdminGirişi_Click(object sender, RoutedEventArgs e)
        {
            HataMesajı = null;
            foreach (Admin Ad in Veri.Adminler)
            {
                if (Ad.NickName!=TxtNickname.SelectedValue.ToString() &&Ad.Şifre!=PbŞifre.Password)
                {
                    HataMesajı += "Nickname Veya Şifre yanlış";
                }
            }
            if (TxtRandomGüvenlikNumarası.Text != TbRandomGüvenlikNumarası.Text )
            {
                HataMesajı += "\nGüvenlik Kodunu Doğru Giriniz";
                RandomGüvenlikNumarasıÜret();
                TxtRandomGüvenlikNumarası.Text = null;
            }
            if (HataMesajı != null)
            {
                MessageBox.Show(HataMesajı);
            }
            else
            {
                NavigationService.Navigate(new AdminPaneli(TxtNickname.SelectedItem as Admin));
            }

        }

        private void BtnÜret_Click(object sender, RoutedEventArgs e)
        {
            RandomGüvenlikNumarasıÜret();            
        }

        private void RandomGüvenlikNumarasıÜret()
        {
            Ü1 = rdn.Next(0, Karakterler.Count);
            Ü2 = rdn.Next(0, Karakterler.Count);
            Ü3 = rdn.Next(0, Karakterler.Count);
            Ü4 = rdn.Next(0, Karakterler.Count);
            Ü5 = rdn.Next(0, Karakterler.Count);
            Ü6 = rdn.Next(0, Karakterler.Count);
            TbRandomGüvenlikNumarası.Text = $"{Karakterler[Ü1]}{Karakterler[Ü2]}{Karakterler[Ü3]}{Karakterler[Ü4]}{Karakterler[Ü5]}{Karakterler[Ü6]}";
        }
    }
}
