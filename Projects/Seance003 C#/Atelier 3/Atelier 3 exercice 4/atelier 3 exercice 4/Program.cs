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
            argumentValeurReference();
            Console.ReadLine();

        }
       

        private static void modifierValeurReference(ref int o)

        {
            o = 4;
        }
        private static void argumentValeurReference()
        {
            int s = 3;
            Console.WriteLine("Valeur avant appel méthode modification valeur {0}", s);
            modifierValeurReference(ref s);
            Console.WriteLine("Valeur avant appel méthode modification valeur {0}", s);
        }

    }
}





