using AdatPanel.Objects;
using Server;
using Server.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Insert_Window window = new Insert_Window();
            window.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Delete_Window window = new Delete_Window();
            window.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Update_window window = new Update_window();
            window.Show();
        }

        private void Refresh(object sender, RoutedEventArgs e)
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
    }
}
