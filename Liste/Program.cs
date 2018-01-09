using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liste
{
    class Program
    {
        static void Main(string[] args)
        {

            //Définition de la liste
            List<string> jours = new List<string>();

            //pour ajouter Lundi, Mardi, Mercredi
            jours.Add("lundi");
            jours.Add("Mardi");
            jours.Add("Mercredi");


            //Pour Afficher une liste
            foreach (string j in jours)
            {
                Console.WriteLine(j);
            }

            Console.ReadLine();
        }
    }
}
