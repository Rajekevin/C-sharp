using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiviliteAge
{
    public class Questionnaire
    {
        public static void Civilite()
        {
            Console.WriteLine("Donnez votre civilité");
            string s = Console.ReadLine();
            Console.WriteLine(  (s.ToLower() == "mme") ? "Bonjour Madame ! " : "Bonjour Monsieur ! ");
        }


        public static void Age()
        {
            Console.WriteLine("Donnez votre Age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine((age >= 18 ) ? "Vous êtes majeur ! " : "Vous êtes mineur ! ");
            Console.ReadLine();
        }

    }
}