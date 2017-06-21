using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier1
{
    class Program
    {
        static void Main(string[] args)
        {
            int premierNombre = AcquerirNombre();
            int deuxiemeNombre = AcquerirNombre();
            Console.WriteLine("La somme de {0} et {1} est {2}", premierNombre, deuxiemeNombre, sommerNombres(premierNombre, deuxiemeNombre));
            Console.ReadLine();
        }
        static int AcquerirNombre()
        {
            string nombre1;
            int nombreSaisi;
            bool result1 = false;
            do
            {
                Console.WriteLine("Veuillez saisir un nombre entier");
                nombre1 = Console.ReadLine();
                result1 = int.TryParse(nombre1, out nombreSaisi);
            } while (result1 != true);
            return nombreSaisi;
            Console.WriteLine("Merci");
        }
        static int sommerNombres(int premierNombre, int deuxiemeNombre)
        {
            return (premierNombre + deuxiemeNombre);
        }
    }
}

