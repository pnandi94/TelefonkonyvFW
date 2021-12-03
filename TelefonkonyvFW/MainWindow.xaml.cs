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

namespace TelefonkonyvFW
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private enTelefonkonyvContainer cnTelefonszamok;
        public MainWindow()
        {
            InitializeComponent();
            cnTelefonszamok = new enTelefonkonyvContainer();
        }

        private void miMentes_Click(object sender, RoutedEventArgs e)
        {
            cnTelefonszamok.SaveChanges();
        }

        private void miKilepes_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void miMindenAdat_Click(object sender, RoutedEventArgs e)
        {
            dgAdatracs.Visibility = Visibility.Visible;
            var er = new List<SzemelyesAdatok>();
            foreach (var x in cnTelefonszamok.enSzemelyek)
            {
                er.Add(new SzemelyesAdatok()
                {
                    Vezeteknev = x.Vezeteknev,
                    Utonev = x.Utonev,
                    Helysegnev=x.enHelyseg.Nev,
                    Irsz=x.enHelyseg.Irsz,
                    Lakcim=x.Lakcim,
                    Telefonszamok=x.Telefonszamok(),
                });
            }

            dgAdatracs.ItemsSource = er;
        }

        private void miHelysegek_Click(object sender, RoutedEventArgs e)
        {
            dgAdatracs.Visibility = Visibility.Visible;

            var er = (from x in cnTelefonszamok.enHelysegek select new { x.Irsz, x.Nev}).ToList();

            dgAdatracs.ItemsSource = er;
        }

        private void miHelysegekAM_Click(object sender, RoutedEventArgs e)
        {
            dgAdatracs.Visibility = Visibility.Collapsed;
            grHelyseg.Visibility = Visibility.Visible;

            grHelyseg.DataContext = cnTelefonszamok.enHelysegek.ToList();
            cbIrsz.SelectedItem = 0;


        }

        private void cbIrsz_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var enAktualis = ((ComboBox)sender).SelectedItem as enHelyseg;
            cbHelysegnev.SelectedItem = enAktualis;

            tbIrsz.Text = enAktualis.Irsz;
            tbHelységnév.Text = enAktualis.Nev;
        }
    }
}
