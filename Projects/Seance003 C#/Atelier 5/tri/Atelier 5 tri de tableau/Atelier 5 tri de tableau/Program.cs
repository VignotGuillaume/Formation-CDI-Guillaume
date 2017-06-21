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
            int[] tabA = tableauInitial();
            
            triParSelection((int[])tabA.Clone());
            

            Console.ReadLine();

        }

        static int[] tableauInitial()
        {
            return new int[10] { 52, 10, 1, 25, 62, 3, 8, 55, 3, 23 };
        }


        static void triParSelection(int[] tabB)

         

        {

            int nombreValeurs = tabB.Length;     
            int i;
            int j;
            int mini;
            int posMini;
            //recherche du mini            
            for (i = 0; i < nombreValeurs; i++)
            {
                mini = tabB[i];
                posMini = i;

                for (j = i + 1; j < nombreValeurs; j++)
                {

                    if (tabB[j] < tabB[i])
                    {
                        mini = tabB[j];
                        posMini = j;
                    }
                }

                do
                {
                    tabB[posMini] = tabB[posMini - 1];
                    posMini = posMini - 1;
                } while (posMini > i);

                tabB[i] = mini;
                foreach (int entier in tabB) { Console.Write(entier); }
            }
            /* static void triBulle()
             {
                 int[] tabA = new int[10] { 52, 10, 1, 25, 62, 3, 8, 55, 3, 23 };*/
        }


    }

			
}
