using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Hava_Yolu_Uygulaması.Sınıflar
{
    public class Admin
    {
        public string AdminAdıSoyadı { get; set; }
        public DateTime AdminDoğumTarihi { get; set; }
        public string AdminNereli { get; set; }
        public BitmapImage AdminGörseli { get; set; }
        public string NickName { get; set; }
        public string Şifre { get; set; }
        public override string ToString()
        {
            return NickName;
        }
    }
}
