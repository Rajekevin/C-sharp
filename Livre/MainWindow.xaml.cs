using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace Livre
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

        private void btnValider_Click(object sender, RoutedEventArgs e)
        {
            //Nom du serveur / nom de la base / mode authentification / compte à utiliser
            SqlConnection cnx = new SqlConnection(
                @"Data Source=DESKTOP-7H2T06B\SQLEXPRESS; Initial Catalog=librairie;  integrated security=True"
                );

            //On teste la connexion
            try
            {
                cnx.Open(); //ouvre la connexion
                MessageBox.Show("Connexion réussie");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("YOUPLA ERREUR DE CONNEXION A LA BASE !!!!");
            }

            //Ajout de nouveau Livre
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Livre VALUES ( @txtboxISBN , @txtboxTitre,  @txtResume)";
            cmd.Connection = cnx;

            cmd.Parameters.AddWithValue("@txtboxISBN", txtboxISBN.Text);
            cmd.Parameters.AddWithValue("@txtboxTitre", txtboxTitre.Text);
            cmd.Parameters.AddWithValue("@txtResume", txtResume.Text);

            //Execution de l'UPDATE
           
            MessageBox.Show("Reader executé");

            int result = cmd.ExecuteNonQuery();

            // Check Error
            if (result < 0) {
                MessageBox.Show("Error inserting data into Database!");
            }
            
            SqlCommand command = cnx.CreateCommand();
            command.CommandText = "SELECT * FROM Livre ";
         
            SqlDataReader dateReader = command.ExecuteReader();
            MessageBox.Show("Reader executé");
            
            while (dateReader.Read())
            {
                string titre = (string)dateReader["titre"];
                listViewAffiche.Items.Add(titre);
            }     
                             
            cnx.Close();
        }

     
    }
}
