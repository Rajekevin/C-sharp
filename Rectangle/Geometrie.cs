using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    public class Geometrie
    {

        public static int PerimetreRectangle(int longueur, int largeur)
        {
            //Périmètre P = (L + l) x 2
            int perimetre = (longueur + largeur) * 2;
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
