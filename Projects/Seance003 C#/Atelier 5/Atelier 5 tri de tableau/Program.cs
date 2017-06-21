using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier_5_tri_de_tableau
{
    class Program
    {

        static void Main(string[] args)
        {
            string reponse;
            int[] tabA = tableauInitial();


            Console.WriteLine("Nous avons le tableau suivant(non trié)");
            Console.WriteLine("52, 10, 1, 25, 62, 3, 8, 55, 3, 23");
            Console.WriteLine(" ");

            Console.WriteLine("Quelle méthode de tri souhaitez vous utiliser?");
            Console.WriteLine(" ");
            Console.WriteLine("S pour tri par selection");
            Console.WriteLine("B pour tri par remontée de bulle");
            Console.WriteLine("R pour generer une serie de nombres aléatoires");
            Console.WriteLine("P pour tri par permutation");            
            Console.WriteLine("F pour sortir du programme");
            reponse = Console.ReadLine();
            switch (reponse)
            {
                case "S":
                    triParSelection((int[])tabA.Clone());
                    Console.ReadLine();
                    break;
                case "B":
                    triBulle((int[])tabA.Clone());
                    Console.ReadLine();
                    break;
                case "R":
                    générerSérie(quantitéDésirée());
                    Console.ReadLine();
                    break;
                case "P":
                    triParPermutation1((int[])tabA.Clone());
                    Console.ReadLine();
                    break;
               
            }
        }

        //---------------------------------------------------------------------------

        static int quantitéDésirée()
        {
            string Saisie;
            int Q;
            Console.WriteLine("Combiens de nombres souhaitez-vous generer(de 1 a 100)?");

            Saisie = Console.ReadLine();
            bool result = int.TryParse(Saisie, out Q);
            return Q;
        }

        static int[] générerSérie(int Z)
        {
            int[] tabRndm = new int[Z];
            Random aléatoireA = new Random();

            Console.WriteLine("Série générée");
            Console.WriteLine(" ");
            if (Z >= 1 & Z <= 100)
            {
                for (int i = 0; i <= tabRndm.GetLength(0) - 1; i++)
                {
                    Console.Write("{0,10}", aléatoireA.Next(0, 100));
                    if ((i + 1) % 10 == 0)
                    {
                        Console.WriteLine();
                    }

                }
            }
            else
            {
                Console.WriteLine("Hors champs");
            }
            return tabRndm;
        }

        //----------------------------------------------------------------------------

        static int[] tableauInitial()
        {
            return new int[10] { 52, 10, 1, 25, 62, 3, 8, 55, 3, 23 };
        }

        static void impressionTableau(int[] tabB)
        {
            Console.WriteLine(" ");
            foreach (int entier in tabB) { Console.Write(entier + " "); }
        }

        //----------------------------------------------------------------------------

        static void triParSelection(int[] tabB)
        {
            int nombreValeurs = tabB.Length;
            int i;
            int j;
            int mini;
            int posMini;
            Console.WriteLine("Option S : Tri par selection :");
            //recherche du mini  
            for (i = 0; i < nombreValeurs; i++)
            {
                mini = tabB[i];
                posMini = i;

                for (j = i + 1; j < nombreValeurs; j++)
                {

                    if (tabB[j] < mini)
                    {
                        mini = tabB[j];
                        posMini = j;
                    }
                }

                for (j = posMini; j == i + 1; j--)
                {
                    tabB[j] = tabB[j - 1];
                }

                do
                {
                    tabB[posMini] = tabB[posMini - 1];
                    posMini = posMini - 1;
                } while (posMini > i);

                tabB[i] = mini;
                impressionTableau(tabB);
            }
        }

        static void triBulle(int[] tabB)
        {
            int nombreValeurs = tabB.Length;

            int i;
            int temp;
            int permut = 0;
            Console.WriteLine("Option B : Tri par remontee de bulle :");
            do
            {
                permut = 0;


                for (i = 0; i < nombreValeurs - 1; i++)
                {
                    if (tabB[i] > tabB[i + 1])
                    {
                        temp = tabB[i];
                        tabB[i] = tabB[i + 1];
                        tabB[i + 1] = temp;
                        permut = 1;
                        impressionTableau(tabB);
                    }
                }
            } while (permut == 1);
        }

        static void triParPermutation1(int[] tabB)
        {
            Console.WriteLine("Option P : Tri par permutation :");       
            int nombreValeurs = tabB.Length;
            int localisation = 0;
            for (int j = 0; j < nombreValeurs ; j++)
            {
                int valeurMini = tabB.Max();

                for (int i = j; i < nombreValeurs ; i++)
                {
                    if (tabB[i] < valeurMini)
                    {
                        valeurMini = tabB[i];
                        localisation = i;
                    }                    
                }
                while (localisation>j)
                {
                    tabB[localisation] = tabB[localisation - 1];
                    localisation = localisation - 1;
                    tabB[localisation] = valeurMini;
                }
                impressionTableau(tabB);                                
            }
        }

        //----------------------------------------------------------------------------
 

    }
}
