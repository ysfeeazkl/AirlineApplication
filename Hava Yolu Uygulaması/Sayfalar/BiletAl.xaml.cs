using Hava_Yolu_Uygulaması.Sınıflar;
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
    /// Interaction logic for BiletAl.xaml
    /// </summary>
    public partial class BiletAl : Page
    {
        BiletAlSınıf Ticket;
        string HataMesajı;
        int a = 0;
        public BiletAl()
        {
            InitializeComponent();
            CbUçuşKodu.ItemsSource = Veri.Uçuşlar;

            BtnKaydet.Click += BtnKaydet_Click;
            BtnTutarHesapla.Click += BtnTutarHesapla_Click;
            BtnAra.Click += BtnAra_Click;

            YetişkenArttırma.Click += YetişkenArttırma_Click;
            ÇocukArttırma.Click += ÇocukArttırma_Click;
            BebekArttırma.Click += BebekArttırma_Click;

            YetişkinEksiltme.Click += YetişkinEksiltme_Click;
            ÇocukEksiltme.Click += ÇocukEksiltme_Click;
            BebekEksiltme.Click += BebekEksiltme_Click;
        }

        private void BtnAra_Click(object sender, RoutedEventArgs e)
        {
            AramaMethodu();
        }

        private void AramaMethodu()
        {
            IEnumerable<BiletAlSınıf> bıletler = Veri.Biletler.AsEnumerable();
            if (TxtArama.Text!=null)
            {
                if (string.IsNullOrWhiteSpace(TxtArama.Text))
                {
                    bıletler = null;
                }
                else
                {
                    bıletler = bıletler.Where(a => a.AdSoyad.ToUpper().StartsWith(TxtArama.Text, StringComparison.CurrentCultureIgnoreCase));
                }
            }
            LbListele.ItemsSource = bıletler;
        }

        private void BtnTutarHesapla_Click(object sender, RoutedEventArgs e)
        {
            HataMesajı = null;
            if (CbUçuşKodu.SelectedIndex == -1)
            {
                HataMesajı += "Uçuş Kodunu Seçiniz";
            }
            if (TxtYetişkinlerSayacı.Text=="0"&& TxtÇocukSayacı.Text == "0" && TxtBebekSayacı.Text == "0")
            {
                HataMesajı += "\nYolcu Sayısını Giriniz";
            }
            if (RbTekYön.IsChecked == false && RbGidişDönüş.IsChecked == false)
            {
                HataMesajı += "\nGidiş-Dönüş Ya Da Tek Yön Olduğunu Giriniz";
            }
            if (HataMesajı!=null)
            {
                MessageBox.Show(HataMesajı);
            }
            else 
            {
                if (RbTekYön.IsChecked==true)
                {
                    UçuşSeferi MilHesaplama = CbUçuşKodu.SelectedItem as UçuşSeferi;
                    int YetişkinSayısı = int.Parse(TxtYetişkinlerSayacı.Text) * 80;
                    int ÇocukSayısı = int.Parse(TxtÇocukSayacı.Text) * 50;
                    int BebekSayısı = int.Parse(TxtBebekSayacı.Text) * 10;
                    TbTutar.Text = $"{MilHesaplama.Mil/ 100 + YetişkinSayısı + ÇocukSayısı + BebekSayısı}";
                }
                if (RbGidişDönüş.IsChecked==true)
                {
                    UçuşSeferi MilHesaplama = CbUçuşKodu.SelectedItem as UçuşSeferi;
                    int YetişkinSayısı = int.Parse(TxtYetişkinlerSayacı.Text) * 80;
                    int ÇocukSayısı = int.Parse(TxtÇocukSayacı.Text) * 50;
                    int BebekSayısı = int.Parse(TxtBebekSayacı.Text) * 10;
                    TbTutar.Text = $"{(MilHesaplama.Mil / 100 + YetişkinSayısı + ÇocukSayısı + BebekSayısı)*2}";
                }
            }
        }

        private void BebekEksiltme_Click(object sender, RoutedEventArgs e)
        {
            int BebekSayaç = int.Parse(TxtBebekSayacı.Text);
            if (BebekSayaç != 0)
            {
                TxtBebekSayacı.Text = $"{BebekSayaç - 1}";
            }
            if (BebekSayaç - 1 == 0)
            {
                BebekEksiltme.IsEnabled = false;
            }
        }

        private void ÇocukEksiltme_Click(object sender, RoutedEventArgs e)
        {
            int ÇocukSayaç = int.Parse(TxtÇocukSayacı.Text);
            if (ÇocukSayaç != 0)
            {
                TxtÇocukSayacı.Text = $"{ÇocukSayaç - 1}";
            }
            if (ÇocukSayaç - 1 == 0)
            {
                ÇocukEksiltme.IsEnabled = false;
            }
        }

        private void YetişkinEksiltme_Click(object sender, RoutedEventArgs e)
        {
            int YetişkinSayaç = int.Parse(TxtYetişkinlerSayacı.Text);
            if (YetişkinSayaç!=0)
            {
                TxtYetişkinlerSayacı.Text = $"{YetişkinSayaç - 1}";
            }
            if(YetişkinSayaç-1==0)
            {
                YetişkinEksiltme.IsEnabled = false;
            }
        }

        private void BebekArttırma_Click(object sender, RoutedEventArgs e)
        {
            int BebekSayaç = int.Parse(TxtBebekSayacı.Text);
            TxtBebekSayacı.Text = $"{BebekSayaç + 1}";
            if (BebekSayaç == 0)
            {
                BebekEksiltme.IsEnabled = true;
            }
        }

        private void ÇocukArttırma_Click(object sender, RoutedEventArgs e)
        {
            int ÇocukSayaç = int.Parse(TxtÇocukSayacı.Text);
            TxtÇocukSayacı.Text = $"{ÇocukSayaç + 1}";
            if (ÇocukSayaç == 0)
            {
                ÇocukEksiltme.IsEnabled = true;
            }
        }

        private void YetişkenArttırma_Click(object sender, RoutedEventArgs e)
        {
            int yetişkinSayaç = int.Parse(TxtYetişkinlerSayacı.Text);
            TxtYetişkinlerSayacı.Text = $"{yetişkinSayaç + 1}";
            if (yetişkinSayaç==0)
            {
                YetişkinEksiltme.IsEnabled = true;
            }
        }

        private void BtnKaydet_Click(object sender, RoutedEventArgs e)
        {
            HataMesajı = null;
            if (string.IsNullOrWhiteSpace(TxtAdSoyad.Text))
            {
                HataMesajı += "Ad-Soyad Giriniz";
            }
            if (string.IsNullOrWhiteSpace(TbTutar.Text))
            {
                HataMesajı += "\nTutar Hesaplayınız";
            }
            if (RbGidişDönüş.IsChecked==false&&RbTekYön.IsChecked==false)
            {
                HataMesajı += "\nGidiş-Dönüş mü? Yoksa Tek Yön mü? Olduğunu Seçiniz";
            }
            if (HataMesajı!=null)
            {
                MessageBox.Show(HataMesajı);
            }
            else
            {                                
            if (RbGidişDönüş.IsChecked==true)
            {
                if (Ticket == null)
                {
                    Ticket = new BiletAlSınıf
                    {
                        AdSoyad = TxtAdSoyad.Text,
                        UçuşKodu = CbUçuşKodu.SelectedItem.ToString(),
                        YetişkinSayısı = int.Parse(TxtYetişkinlerSayacı.Text),
                        ÇocukSayısı = int.Parse(TxtÇocukSayacı.Text),
                        BebekSayısı = int.Parse(TxtBebekSayacı.Text),
                        GidişDönüş = true,
                        TutarHesapla = int.Parse(TbTutar.Text),
                        uçuş=Veri.Uçuşlar[CbUçuşKodu.SelectedIndex]
                    };
                    Veri.Biletler.Add(Ticket);
                }
            }
            if (RbTekYön.IsChecked==true)
            {
                if (Ticket == null)
                {
                    Ticket = new BiletAlSınıf
                    {
                        AdSoyad = TxtAdSoyad.Text,
                        UçuşKodu = CbUçuşKodu.SelectedItem.ToString(),
                        YetişkinSayısı = int.Parse(TxtYetişkinlerSayacı.Text),
                        ÇocukSayısı = int.Parse(TxtÇocukSayacı.Text),
                        BebekSayısı = int.Parse(TxtBebekSayacı.Text),
                        GidişDönüş = false,
                        TutarHesapla = int.Parse(TbTutar.Text),
                        uçuş=Veri.Uçuşlar[CbUçuşKodu.SelectedIndex]
                    };
                    Veri.Biletler.Add(Ticket);
                }
            }
                TxtArama.Text = $"{TxtAdSoyad.Text}";
                TemizlikRobotu();
                
            }
        }

        private void TemizlikRobotu()
        {
            RbGidişDönüş.IsChecked = false;
            RbTekYön.IsChecked = false;
            TxtAdSoyad.Text = null;
            TxtYetişkinlerSayacı.Text = "0";
            TxtÇocukSayacı.Text = "0";
            TxtBebekSayacı.Text = "0";
            CbUçuşKodu.SelectedItem = null;
            TbTutar.Text = null;
        }
    }
}
