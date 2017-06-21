using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SalarieDll;
using System.Threading.Tasks;
using System.Collections;

namespace Atelier_2_tableau_dynamiques
{
    class ProgramTableau
    {


        public static void Main(string[] args)
        {
            CreerListeHeteroclite();


        }

        #region Méthodes

        public static void CreerListeHeteroclite()
        {
            ArrayList tabListeA = new ArrayList();
            tabListeA.Add(0.1m);
            tabListeA.Add(1);
            tabListeA.Add("un");

            Salarie salarie1 = new Salarie();
            salarie1.Nom = "Morillon";
            salarie1.Prenom = "Jean";
            Salarie salarie2 = new Salarie();
            salarie2.Nom = "Henaff";
            salarie2.Prenom = "Marion";
            tabListeA.Add(salarie1);
            tabListeA.Add(salarie2);
            Commercial commercial1 = new Commercial(1000000, 0.5m);
            commercial1.Nom = "Bost";
            commercial1.Prenom = "Vincent";
            tabListeA.Add(commercial1);
            AfficherElements(tabListeA);

        }


        public static void AfficherElements(ArrayList tabListeA)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" --------------------------------------- ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(" DEBUT ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" -------------------------------------------------------------- ");
            Console.ForegroundColor = ConsoleColor.White;


            foreach (object element in tabListeA)
            {
                if (element.GetType() == typeof(int))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("C'est un numerique (entier) : ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("{0}", element.ToString());
                }

                if (element.GetType() == typeof(decimal))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("C'est un numerique (decimal) : ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("{0}", element.ToString());
                }

                if (element.GetType() == typeof(Salarie))
                {

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("C'est un salarié :  ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("{0}", ((Salarie)element).Nom.ToString());
                }

                if (element.GetType() == typeof(Commercial))
                {

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("C'est un commercial :  ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" Nom : {0} ; Taux de commission :{1}", ((Commercial)element).Nom.ToString(),((Commercial)element).Commission.ToString());
                }

                if (element.GetType() == typeof(string))
                {

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("C'est une chaine (string) :  ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("{0}", element.ToString());
                }




                




            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" --------------------------------------- ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(" FIN ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" -------------------------------------------------------------- ");
            Console.ForegroundColor = ConsoleColor.White;

            Console.ReadLine();
        }

        #endregion

       
    }
}
