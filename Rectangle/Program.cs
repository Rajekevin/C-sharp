using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Le Périmètre du Rectangle est de " + Geometrie.PerimetreRectangle());
            Console.WriteLine("L'aire de la surface de Rectangle est de " +Geometrie.SurfaceRectangle(2, 2));
            Console.ReadLine();
        }
    }
}
