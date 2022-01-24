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
    /// Interaction logic for GirişEkranı.xaml
    /// </summary>
    public partial class GirişEkranı : Page
    {
        public GirişEkranı()
        {
            InitializeComponent();
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            RadioButton Rb = sender as RadioButton;
            FrmEkran.Source = new Uri($"{Rb.Tag}", UriKind.Relative);
        }
    }
}
