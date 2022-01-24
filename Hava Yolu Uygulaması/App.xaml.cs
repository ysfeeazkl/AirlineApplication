using Hava_Yolu_Uygulaması.Sınıflar;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Hava_Yolu_Uygulaması
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            #region Adminler
            Veri.Adminler.Add(new Admin
            {
                AdminAdıSoyadı = "Emirhan Güvenç",
                AdminDoğumTarihi = new DateTime(2003, 12, 17),
                AdminNereli = "Giresun",
                AdminGörseli = new BitmapImage(new Uri("/KocaKafalar/Males/C04.png", UriKind.Relative)),
                NickName = "TREmireis",
                Şifre="çokgüvenliklişifre1234"
            });
            #endregion

            #region UçuşSeferleri

            Veri.Uçuşlar.Add(new UçuşSeferi()
            {
                UçuşTarihi = new DateTime(2020,10,03),
                KalkışSaati = "12:21",
                HavaYolu=new BitmapImage(new Uri("/Resimler/Pegasus.jpeg",UriKind.Relative)),
                UçuşNO="TK 2790",
                KalkacağıKonum="İstanbul",
                Mil=154,
                VaracağıKonum="Ankara",
                BagajKapistesi=23
            });

            Veri.Uçuşlar.Add(new UçuşSeferi()
            {
                UçuşTarihi = new DateTime(2020,03,12),
                KalkışSaati = "18:50",
                HavaYolu = new BitmapImage(new Uri("/Resimler/Qatar.jpeg", UriKind.Relative)),
                UçuşNO = "HJ 5055",
                KalkacağıKonum = "İstanbul",
                Mil=2185,
                VaracağıKonum = "Madrid",
                BagajKapistesi = 25
            });

            Veri.Uçuşlar.Add(new UçuşSeferi()
            {
                UçuşTarihi = new DateTime(2020, 10, 04),
                KalkışSaati = "12:25",
                HavaYolu = new BitmapImage(new Uri("/Resimler/Qatar.jpeg", UriKind.Relative)),
                UçuşNO = "LS 5278",
                KalkacağıKonum = "Mardin",
                Mil = 687,
                VaracağıKonum = "Afyon",
                BagajKapistesi = 28
            });

            Veri.Uçuşlar.Add(new UçuşSeferi()
            {
                UçuşTarihi = new DateTime(2020, 08, 13),
                KalkışSaati = "11:00",
                HavaYolu = new BitmapImage(new Uri("/Resimler/Qatar.jpeg", UriKind.Relative)),
                UçuşNO = "PO 7924",
                KalkacağıKonum = "Tahran",
                Mil = 1524,
                VaracağıKonum = "İstanbul",
                BagajKapistesi = 25
            });

            Veri.Uçuşlar.Add(new UçuşSeferi()
            {
                UçuşTarihi = new DateTime(2020,05,25),
                KalkışSaati = "22:00",
                HavaYolu = new BitmapImage(new Uri("/Resimler/TürkHavaYolları.jpeg", UriKind.Relative)),
                UçuşNO = "KJ 7359",
                Mil=1417,
                KalkacağıKonum = "İstanbul",
                VaracağıKonum = "Bakü",
                BagajKapistesi = 27
            });

            Veri.Uçuşlar.Add(new UçuşSeferi()
            {
                UçuşTarihi = new DateTime(2020, 12, 05),
                KalkışSaati = "12:30",
                HavaYolu = new BitmapImage(new Uri("/Resimler/TürkHavaYolları.jpeg", UriKind.Relative)),
                UçuşNO = "GU 7392",
                Mil = 1364,
                KalkacağıKonum = "İstanbul",
                VaracağıKonum = "Berlin",
                BagajKapistesi = 23
            });

            Veri.Uçuşlar.Add(new UçuşSeferi()
            {
                UçuşTarihi = new DateTime(2020, 03, 09),
                KalkışSaati = "03:30",
                HavaYolu = new BitmapImage(new Uri("/Resimler/TürkHavaYolları.jpeg", UriKind.Relative)),
                UçuşNO = "TC 7479",
                Mil = 3955,
                KalkacağıKonum = "Giresun",
                VaracağıKonum = "Pekin",
                BagajKapistesi = 25
            });

            #endregion

            #region Biletler

            Veri.Biletler.Add(new BiletAlSınıf()
            {
                AdSoyad = "Veli Tembel",
                GidişDönüş = true,
                UçuşKodu = Veri.Uçuşlar[0].UçuşNO.ToString(),
                YetişkinSayısı=1,
                ÇocukSayısı=0,
                BebekSayısı=0,
                TutarHesapla=150,
                uçuş = Veri.Uçuşlar[0]
            });

            Veri.Biletler.Add(new BiletAlSınıf()
            {
                AdSoyad = "Aslı Ortaşeker",
                GidişDönüş = false,
                UçuşKodu = Veri.Uçuşlar[1].UçuşNO.ToString(),
                YetişkinSayısı = 1,
                ÇocukSayısı = 1,
                BebekSayısı = 0,
                TutarHesapla = 90,
                uçuş = Veri.Uçuşlar[1]
            });

            Veri.Biletler.Add(new BiletAlSınıf()
            {
                AdSoyad = "Ahmet Karnıyarık",
                GidişDönüş = true,
                UçuşKodu = Veri.Uçuşlar[2].UçuşNO.ToString(),
                YetişkinSayısı = 2,
                ÇocukSayısı = 2,
                BebekSayısı = 0,
                TutarHesapla = 180,
                uçuş = Veri.Uçuşlar[2]
            });

            #endregion
        }
    }
}
