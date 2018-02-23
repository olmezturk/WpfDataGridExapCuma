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

namespace WpfSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Customers> list;
        public MainWindow()
        {
            InitializeComponent();
            list = new List<Customers>()
            {
                new Customers() { AD="Ali",SOYAD="Kazık" },
                new Customers() { AD="Veli",SOYAD="Veled" },
                new Customers() { AD="Vedat",SOYAD="Edat" },
                new Customers() { AD="Mami",SOYAD="Taze" },
                new Customers() { AD="Mavi",SOYAD="Pembe" },
            };
            Customers liste = new Customers();
            {
                liste.AD = "Caner";
                liste.SOYAD = "Patates";
          
                list.Add(liste);
            }

        }

        private void btntikla_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Butona Tıklandı.");
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show(cmbBoxListe.SelectedItem.ToString());

            MessageBox.Show(((ComboBoxItem)(cmbBoxListe.SelectedItem)).Content.ToString());
        }
        public void Window_Load(object sender, RoutedEventArgs e)
        {
            tb1.ItemsSource = list;
        }
    }
internal class Customers
{
    public string AD { get; internal set; }
    public string SOYAD { get; internal set; }
}
    
}
