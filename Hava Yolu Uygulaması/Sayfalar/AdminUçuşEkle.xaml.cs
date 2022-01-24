using Hava_Yolu_Uygulaması.Sınıflar;
using Microsoft.Win32;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hava_Yolu_Uygulaması.Sayfalar
{
    /// <summary>
    /// Interaction logic for AdminUçuşEkle.xaml
    /// </summary>
    public partial class AdminUçuşEkle : Page
    {
        OpenFileDialog OFD;
        BitmapImage sResim;
        Random rdn = new Random();
        string HataMesajı;
        UçuşSeferi uç;
        int U1, U2, U3, U4, U5, U6;
        List<string> Harfler = new List<string>() { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        List<string> Sayılar = new List<string>() { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        public AdminUçuşEkle()
        {
            InitializeComponent();           
            ImgHavaYolu.MouseDown += ImgHavaYolu_MouseDown;
            BtnKaydet.Click += BtnKaydet_Click;
        }

        private void BtnKaydet_Click(object sender, RoutedEventArgs e)
        {
            HataMesajı = null;
            int a = int.Parse(TxtUzaklık.Text);
            double j = a / 1.5;
            U1 = rdn.Next(0, Harfler.Count);
            U2 = rdn.Next(0, Harfler.Count);
            U3 = rdn.Next(0, Sayılar.Count);
            U4 = rdn.Next(0, Sayılar.Count);
            U5 = rdn.Next(0, Sayılar.Count);
            U6 = rdn.Next(0, Sayılar.Count);
            if (DpTarih.SelectedDate == null)
            {
                HataMesajı += "TarihSeçiniz";
            }
            if (string.IsNullOrWhiteSpace(TxtKalkışSaati.Text))
            {
                HataMesajı += "\nKalkış Saatini Giriniz";
            }
            if (sResim == null)
            {
                HataMesajı += "\nHava Yolu Resmini Seçiniz";
            }
            if (string.IsNullOrWhiteSpace(TxtUzaklık.Text))
            {
                HataMesajı += "\nUzaklığı Giriniz";
            }
            if (string.IsNullOrWhiteSpace(TxtKalkacağıKonum.Text))
            {
                HataMesajı += "\nKalkacağı Konumu Giriniz";
            }
            if (string.IsNullOrWhiteSpace(TxtVaracağıKonum.Text))
            {
                HataMesajı += "\nVaracağı Konumu Giriniz";
            }
            if (string.IsNullOrWhiteSpace(TxtBagajKapistesi.Text))
            {
                HataMesajı += "\nBagaj Kapistesini Giriniz";
            }
            if (HataMesajı != null)
            {
                MessageBox.Show(HataMesajı);
            }
            else if(HataMesajı==null)
            {
                if (uç == null)
                {
                    uç = new UçuşSeferi
                    {
                        BagajKapistesi = int.Parse(TxtBagajKapistesi.Text),
                        KalkışSaati = TxtKalkışSaati.Text,
                        HavaYolu = sResim,
                        Mil = j,
                        UçuşTarihi = DpTarih.SelectedDate.Value,
                        KalkacağıKonum = TxtKalkacağıKonum.Text,
                        VaracağıKonum = TxtVaracağıKonum.Text,
                        UçuşNO = $"{Harfler[U1]}{Harfler[U2]}  {Sayılar[U3]}{Sayılar[U4]}{Sayılar[U5]}{Sayılar[U6]}"
                    };
                    Veri.Uçuşlar.Add(uç);                    
                }
            }
        }

        private void ImgHavaYolu_MouseDown(object sender, MouseButtonEventArgs e)
        {
            OFD = new OpenFileDialog
            {
                Filter = "Resim Dosyaları |*.jpg;*.bmp;*.jpeg;*.png;| Tüm Dosyalar|*.*"
            };
            if (OFD.ShowDialog() == true)
            {
                sResim = new BitmapImage(new Uri(OFD.FileName));
                ImgHavaYolu.Source = sResim;
            }
        }

    }
}
