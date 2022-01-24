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
    /// Interaction logic for AdminUçuşSeferleri.xaml
    /// </summary>
    public partial class AdminUçuşSeferleri : Page
    {
        public AdminUçuşSeferleri()
        {
            InitializeComponent();
            TxtAra.TextChanged += TxtAra_TextChanged;
            DgListele.ItemsSource = Veri.Uçuşlar.OrderBy(a => a.UçuşTarihi);
        }

        private void TxtAra_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TxtAra.Text != null)
            {
                DgListele.ItemsSource = Veri.Uçuşlar.Where(a => a.UçuşNO.ToUpper().ToString().StartsWith(TxtAra.Text, StringComparison.CurrentCultureIgnoreCase)).OrderBy(t => t.UçuşTarihi);
            }
            else
            {
                DgListele.ItemsSource = Veri.Uçuşlar.OrderBy(a => a.UçuşTarihi);
            }
        }
    }
}
