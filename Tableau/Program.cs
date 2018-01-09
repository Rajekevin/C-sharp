using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tableau
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Donnez la taille de votre tableau :");
            int n = int.Parse(Console.ReadLine());

            Tableaux.SommeTab(Tableaux.SaisieTab(n));
            Console.ReadLine();
        }
    }
}
