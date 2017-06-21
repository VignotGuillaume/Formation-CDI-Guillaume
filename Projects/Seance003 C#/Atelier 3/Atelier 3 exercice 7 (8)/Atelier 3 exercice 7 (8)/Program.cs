using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier_3_exercice_7__8_
{

    class Program
    {

        static void Main(string[] args)

        {
            Console.WriteLine("methode par valeur");
            valeurBase();  //appel de cette fonction
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("methode par reference");
            valeurRef(); //appel de cette fonction  
            Console.ReadLine();
        }



        private static void valeurBase()
        {
            string s = "bonjour";
            string o = "au revoir";
            string temp = "null";

            Console.WriteLine("Valeur avant appel méthode echange bonjour = {0} et au revoir = {1} ", s, o);
            //appel de la fonction qui permute (par valeur, donc inutile ici puisque realisée dans une autre fonction)
            permutationVal(s, o, temp);
            Console.WriteLine("Valeur aprés appel méthode echange bonjour = {0} et au revoir = {1} ", s, o);
        }


        private static void permutationVal(string s, string o, string temp)
        {
            temp = s;
            s = o;
            o = temp;
        }








        private static void valeurRef()
        {
            string s = "bonjour";
            string o = "au revoir";
            string temp = "null";

            Console.WriteLine("Valeur avant appel méthode echange bonjour = {0} et au revoir = {1} ", s, o);
            //appel de la fonction qui permute (par reference, donc utile ici puisque memesi realisée dans une autre fonction c'est la reference qui est appellée ici)
            permutationRef(ref s, ref o, ref temp);
            Console.WriteLine("Valeur aprés appel méthode echange bonjour = {0} et au revoir = {1} ", s, o);
        }

        private static void permutationRef(ref string s, ref string o, ref string temp)
        {
            temp = s;
            s = o;
            o = temp;
        }

    }
}





