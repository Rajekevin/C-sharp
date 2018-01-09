using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tableau
{
   public class Tableaux
    {


        public static int SommeTab(int[] tab)
        {
            int sommeTab = 0;
            for(int i=0; i<tab.Length; i++)
            {
             sommeTab = tab[i] + sommeTab;
            }
            return sommeTab;
        }

        public static int[] SaisieTab(int x)
        {
            int[] vTab = new int[x];

            for (int i = 0; i< vTab.Length; i++) {

                Console.Write("Donnez l'élèment numéro" + i + ":");
                vTab[i] = int.Parse(Console.ReadLine());
            }

            return vTab;
 
        }

    }
}
