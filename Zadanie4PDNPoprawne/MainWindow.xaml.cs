using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Zadanie4PDNPoprawne
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var index = DataGridMain.SelectedIndex;
            var provider = new XmlDataProvider();
            provider.Source = new Uri("Pliki\\Input.xml", UriKind.Relative);
            provider.XPath = $"Lista/Kategoria[{index+1}]/Podkategoria";

            var oknoKategorii = new OknoKategorii(index);
            oknoKategorii.GridKategorii.DataContext = provider;
            oknoKategorii.Show();
        }
    }
}