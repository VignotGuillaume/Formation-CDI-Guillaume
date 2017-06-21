using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Poo1;

namespace POO1Test
{
    class Program
    {
        static void Main(string[] args)
        {

            Salarie sal=null ;
            Salarie sal1 = null;
            Salarie sal2 = null;
            try
            {
                string s = new String(new char[] {'a','b'});
               
                sal = new Salarie("Bost", "Vincent", "12aaa55");        
                sal.DateNaissance = new DateTime(2000, 05, 29);
                sal.SalaireBrut = 1980.25m;
                sal.TauxCS = .30m;
                sal1 = new Salarie("Bost", "Vincent", "12aaa55");
                sal1.DateNaissance = new DateTime(2000, 05, 29);
                sal1.SalaireBrut = 1980.25m;
                sal1.TauxCS = .30m;
                sal2 = new Salarie("Bost", "Vincent", "12aaa55");
                sal2.DateNaissance = new DateTime(2000, 05, 29);
                sal2.SalaireBrut = 1980.25m;
                sal2.TauxCS = .30m;
           
            }
            catch (Exception e )
            {
               
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(@"Le salarié {0} {1} a été créé et son salaire net est de {2:n} euros", sal.Prenom, sal.Nom,sal.SalaireNet);
            Console.WriteLine("Etape 1 Le nombre d'instances en mémoire de salariés est de {0}", Salarie.NombreInstances);
            Console.WriteLine("Appuyez sur la touche Entrée pour détruire la référence au salarié");
            Console.ReadLine();
            sal = null;
            sal1 = null;
            sal2 = null;
            Console.WriteLine("Etape 2 Le nombre d'instances en mémoire de salariés est toujours de {0}", Salarie.NombreInstances);
            Console.WriteLine("Appuyez sur la touche Entrée pour demander au Garbage Collector de nettoyer le tas");
            Console.ReadLine();
            GC.Collect();
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Etape 3 Le nombre d'instances en mémoire de salariés est de {0}", Salarie.NombreInstances);
            Console.ReadLine();

        }
    }
}
