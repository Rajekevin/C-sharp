using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            AfficherBienvenue();
            GoodBye();
            DisplaySentence("Bonjour les amis");
        }

        private static void DisplaySentence(string word)
        {
            Console.WriteLine(word);
            Console.ReadLine();
        }

        static void AfficherBienvenue()
        {
            Console.WriteLine("Welcome");
            Console.ReadLine();
        }

        static void GoodBye()
        {
            Console.WriteLine("Good Bye ! ");
            Console.ReadLine();
        }

    }

}
