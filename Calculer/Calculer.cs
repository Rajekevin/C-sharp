using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculer
{
   public class Calculer
    {

        //Addition 
        public static int Addition(int EntierA, int EntierB)
        {
            Console.WriteLine("Addition");
            Console.ReadLine();
            int sommeValeur = EntierA + EntierB;
            return sommeValeur;           
        }

        //Soustraction
        public static int Soustraction()
        {
            Console.WriteLine("Soustraction");
            Console.ReadLine();

            //Saisie de l'Entier 1
            Console.WriteLine("Veuillez saisir votre Entier 1 ");
            string saisieA = Console.ReadLine();
            int.TryParse(saisieA, out int EntierA); //Conversion de char en int

            //Saisie de l'Entier 2
            Console.WriteLine("Veuillez saisir votre Entier 2");
            string saisieB = Console.ReadLine();    
            int.TryParse(saisieB, out int EntierB); //Conversion de char en int
            
            //Calcul de la Soustraction
            int sommeValeur = EntierA - EntierB;
            return sommeValeur;
        }

    }
}
