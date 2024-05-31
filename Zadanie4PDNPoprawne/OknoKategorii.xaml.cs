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
using System.Windows.Shapes;

namespace Zadanie4PDNPoprawne
{
    /// <summary>
    /// Logika interakcji dla klasy OknoKategorii.xaml
    /// </summary>
    public partial class OknoKategorii : Window
    {
        public OknoKategorii(int index)
        {
            InitializeComponent();
            mainIndex = index;
        }

        private readonly int mainIndex;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var index = DataGridKat.SelectedIndex;
            var provider = new XmlDataProvider();
            provider.Source = new Uri("Pliki\\Input.xml", UriKind.Relative);
            provider.XPath = $"Lista/Kategoria[{mainIndex + 1}]/Podkategoria[{index+1}]/Model";

            var oknoModelu= new OknoModelu();
            oknoModelu.GridKategorii.DataContext = provider;
            oknoModelu.Show();
        }
    }
}
