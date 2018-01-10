using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace MyWpf
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnDB_Click(object sender, RoutedEventArgs e)
        {
            //1- créer une chaine de connexion
            //Nom du serveur / nom de la base / mode authentification / compte à utiliser
            SqlConnection cnx = new SqlConnection(
                @"Data Source=DESKTOP-7H2T06B\SQLEXPRESS; Initial Catalog=park;  integrated security=True"
                );

            cnx.Open(); //ouvre la connexion
            MessageBox.Show("Connexion réussie");

            //SqlCommand cmd = new SqlCommand();

            //cmd.CommandText("select * from ordinateur");

            /*cmd.Connection = cnx;

            SqlDataReader dateReader = cmd.ExecuteReader();
            MessageBox.Show("Reader executé");
            

            while (dateReader.Read())
            {
                string desg = (string)dateReader["designation"];

                lstAffichage.Items.Add(desg);

            }*/


        }
    }
}
