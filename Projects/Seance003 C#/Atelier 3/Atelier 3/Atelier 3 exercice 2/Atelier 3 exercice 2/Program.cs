using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier_3_exercice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            a = 1;
            b = a;
            b = b + 9;
            Console.WriteLine("valeur de a = {0} et valeur de b = {1} ", a, b); 
            int[] tabA, tabB;
            tabA = new int [3] { 2, 5,4};
            tabB = tabA;
            tabB[0] = 15;

            Console.WriteLine(" ");
            Console.WriteLine("valeurs du tableau a= ");
            foreach (int valeur in tabA)
            {
                Console.Write(valeur+" ");
               

            }
            Console.WriteLine("\n valeur de la premiere position \n{0}  ",tabA[0]);
            Console.WriteLine(" ");


            Console.WriteLine("valeurs du tableau b= ");
           
            foreach (int valeur in tabB)
            {
                Console.Write(valeur+" ");
                
            }
            Console.WriteLine("\n valeur de la premiere position \n{0}  ", tabB[0]);



            Console.ReadLine();

        }
    }
}
