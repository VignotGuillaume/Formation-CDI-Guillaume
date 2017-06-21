using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier_3_exercice_3
{
    class Program
    {

        static void Main(string[] args)

        {
            argumentValeur();
            Console.ReadLine();

        }


        private static void modifierTabValeur(int[] tabO)

        {
            tabO[0] = 8;
        }
        private static void argumentValeur()
        {
            int[] tabS = new int[3] { 1, 4, 6 };
            Console.WriteLine("Valeur avant appel méthode modification valeur {0} et {1}", tabS[0], tabS[1]);
            //modifierTabValeur(tabS);
            modifierTabValeur2(ref tabS);
            Console.WriteLine("Valeur avant appel méthode modification valeur {0} et {1}", tabS[0], tabS[1]);
        }
        private static void modifierTabValeur2(ref int [] tabO)

        {
            tabO[0] = 8;
            tabO = new int [] { 9, 10, 11 };
        }

    }
}


