using AdatPanel.Objects;
using Server.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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
    /// Interaction logic for Delete_Window.xaml
    /// </summary>
    public partial class Delete_Window : Window
    {
        public Delete_Window()
        {
            InitializeComponent();
        }

        private void DELETE_btn_Click(object sender, RoutedEventArgs e)
        {
            FelhasznalokController controller = new FelhasznalokController();
            Felhasznalo felhasznalo = new Felhasznalo();
            felhasznalo.Id = int.Parse(ID_textbox.Text);
            controller.Delete(felhasznalo);

            MessageBox.Show("Felhasználó törölve");
            Close();
        }
    }
}
