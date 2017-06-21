using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stagiaires;

namespace GestionStagiaires
{
    class Program
    {
        static void Main(string[] args)
        {
            Stagiaire stag1 = new Stagiaire();
            Stagiaire stag2 = stag1;

            stag2.DateNaissance = new DateTime(1986,10,13);
            stag2.Nom = "Damien";
            Console.WriteLine("Age de {0} est {1} !", stag2.Nom, stag2.Age);
            //stag2.Age;

            Console.ReadLine();
        }
    }
}
