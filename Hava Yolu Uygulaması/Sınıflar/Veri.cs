using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hava_Yolu_Uygulaması.Sınıflar
{
    public static class Veri
    {
        public static ObservableCollection<UçuşSeferi> Uçuşlar = new ObservableCollection<UçuşSeferi>();
        public static ObservableCollection<BiletAlSınıf> Biletler = new ObservableCollection<BiletAlSınıf>();
        public static ObservableCollection<Admin> Adminler = new ObservableCollection<Admin>();
    }
}
