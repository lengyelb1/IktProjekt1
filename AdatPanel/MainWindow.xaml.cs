using Server;
using Server.Controllers;
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

namespace AdatPanel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            FelhasznalokController felhasznalokController = new FelhasznalokController();
            List<Record> records = felhasznalokController.Select();
            List<Felhasznalo> lista = new List<Felhasznalo>();
            foreach (Record record in records)
            {
                lista.Add(record as Felhasznalo);
            }
            InitializeComponent();
            dg_adatok.ItemsSource = lista;

        }

        private void dg_adatok_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
