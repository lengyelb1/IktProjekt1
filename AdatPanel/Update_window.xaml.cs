using AdatPanel.Objects;
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
    /// Interaction logic for Update_window.xaml
    /// </summary>
    public partial class Update_window : Window
    {
        public Update_window()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FelhasznalokController controller = new FelhasznalokController();
            Felhasznalo felhasznalo = new Felhasznalo();
            felhasznalo.Id = int.Parse(ID.Text);
            felhasznalo.LoginNev = Login_Nev.Text;
            felhasznalo.HASH = HASH.Text;
            felhasznalo.SALT = SALT.Text;
            felhasznalo.Nev = Nev.Text;
            felhasznalo.Jog = byte.Parse(Jog.Text);
            felhasznalo.Aktiv = bool.Parse(Akitv.Text);
            felhasznalo.Email = Email.Text;
            felhasznalo.ProfilKep = Profil_Kep.Text;

            controller.Update(felhasznalo);

            MessageBox.Show("Felhasználó Frissítve");
            
            Close();
            
        }
    }
}
