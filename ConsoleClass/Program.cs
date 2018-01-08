using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //A partir de ce main on appel la méthode 
            //AfficheParam de la classe Afficher
            /* POUR CELA, LA CLASSE AFFICHER SOIT VISIBLE OU PUBLIC */

            Display.AfficheParam("bonjour depuis ma méthode de DISPLAY");
            Display.AfficheParam("Au revoir");

        }
    }
}
