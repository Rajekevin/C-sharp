using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfTest
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

          
            InitializeComponent();
            InitializeCbMarque();
        }

        private void InitializeCbMarque()
        {
         // textboxNom.Items.Add('DELL');

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /*  string s = textboxCPU1.Text+ " " + textboxNom.Text+ " " + textboxRam.Text;              
              MessageBox.Show(s);


              listviewAffiche.Items.Add(s);*/
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == true)
            {
                string s = ofd.FileName;
                imgArticle.Source = new BitmapImage(new Uri(s));
            }

        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog odf = new OpenFileDialog();

            if(odf.ShowDialog() == true)
            {

                string textAInserer = "";
                //On écrit le fichier
                //Le contenu de notre fichier
                foreach (string item in listviewAffiche.Items)
                {
                    textAInserer = textAInserer + "\r\n" + item;
                }

                File.WriteAllText(odf.FileName, textAInserer);


            }
        }
    }
}
