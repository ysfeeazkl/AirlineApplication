using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hava_Yolu_Uygulaması.Sınıflar
{
    public class BiletAlSınıf
    {
        public string AdSoyad { get; set; }
        public bool GidişDönüş { get; set; }
        public string UçuşKodu { get; set; }
        public int YetişkinSayısı { get; set; }
        public int ÇocukSayısı { get; set; }
        public int BebekSayısı { get; set; }
        public int TutarHesapla { get; set; }
        public UçuşSeferi uçuş { get; set; }
        public override string ToString()
        {
            return UçuşKodu;
        }
    }
}
