using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    public class Geometrie
    {

        public static double PerimetreRectangle()
        {
            int longueur;
            double largeur;
            //Périmètre P = (L + l) x 2

            Console.WriteLine("Donnez la longueur du Rectangle");            
            longueur = int.Parse(Console.ReadLine());

            Console.WriteLine("Donnez la longueur du Rectangle");          
            largeur = double.Parse(Console.ReadLine());

            double perimetre = (longueur + largeur) * 2;
            return perimetre;
        }

        public static int SurfaceRectangle(int longueur, int largeur)
        {
            //Aire = L x l
            int aire = longueur * largeur;
            return aire;
        }

    }
}
