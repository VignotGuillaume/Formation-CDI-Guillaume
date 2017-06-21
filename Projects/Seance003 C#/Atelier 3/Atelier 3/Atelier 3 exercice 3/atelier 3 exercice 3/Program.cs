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
        private static void argumentValeur()
        {
            int s = 3;
            Console.WriteLine("Valeur avant appel méthode modification valeur {0}", s);
            modifierValeur(s);
            Console.WriteLine("Valeur avant appel méthode modification valeur {0}", s);
        }

        private static void modifierValeur(int o)

        {
            o = 4;
        }
















    }
}
