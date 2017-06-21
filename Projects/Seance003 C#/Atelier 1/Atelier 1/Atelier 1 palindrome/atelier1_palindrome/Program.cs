using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier1_palindrome
{
    class Program
    {

        static void Main(string[] args)
        {

            if (Comparer(AcquisitionChaine()))
            {
                Console.WriteLine("ceci est  un palindrome");

            }
            else
            {
                Console.WriteLine("ceci n'est pas  un palindrome");
            }
            Console.ReadLine();
        }


        static string AcquisitionChaine()
        {
            Console.WriteLine("Veuillez saisir une chaine");
            string chaineCharAq = Console.ReadLine();
            return chaineCharAq;

        }

        static bool Comparer(string chaineChar)
        {
            bool comparaison;
            int lng = chaineChar.Length;
            Console.WriteLine("longueur : " + lng);
            int i = 0;
            int j = lng - 1;

            do
            {
                comparaison = (chaineChar[i] == chaineChar[j]);
                i++;
                j--;

                if (!comparaison)
                {
                    i = j;

                }

            } while (i < j);

            return comparaison;
        }
    }
}