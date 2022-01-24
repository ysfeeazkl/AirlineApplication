using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Hava_Yolu_Uygulaması.Sınıflar
{
    public class UçuşSeferi
    {
        public DateTime UçuşTarihi { get; set; }
        public string KalkışSaati { get; set; }
        public BitmapImage HavaYolu { get; set; }
        public double Mil { get; set; }
        public string UçuşNO { get; set; }
        public string KalkacağıKonum { get; set; }
        public string VaracağıKonum { get; set; }
        public int BagajKapistesi { get; set; }
        public override string ToString()
        {
            return UçuşNO;
        }
    }
}
