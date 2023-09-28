using AdatPanel.Objects;
using MySql.Data.MySqlClient;
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
using System.Windows.Shapes;

namespace AdatPanel
{
    /// <summary>
    /// Interaction logic for Insert_Window.xaml
    /// </summary>
    public partial class Insert_Window : Window
    {
        public Insert_Window()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FelhasznalokController controller = new FelhasznalokController();
            Felhasznalo felhasznalo = new Felhasznalo();
            
            felhasznalo.LoginNev = Login_Nev.Text;
            felhasznalo.HASH = HASH.Text;
            felhasznalo.SALT = SALT.Text;
            felhasznalo.Nev = Nev.Text;
            felhasznalo.Jog = byte.Parse(Jog.Text);
            felhasznalo.Aktiv = bool.Parse(Akitv.Text);
            felhasznalo.Email = Email.Text;
            felhasznalo.ProfilKep = Profil_Kep.Text;

            controller.Insert(felhasznalo);

            MessageBox.Show("Felhasználó feltöltve");
            Close();
        }
    }
}
