﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier3_exercice1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombreSaisi;
            int a;
            short b;
            long c;

            Console.WriteLine("Veuillez saisir un nombre");
            nombreSaisi = Console.ReadLine();
            a = int.Parse(nombreSaisi);
            b = (short) a++;
            c = ++a;
            Console.WriteLine("a={0} , b={1},c={2} ", a,b,c);
            Console.WriteLine("c est issue d'une conversion implicite car sans perte de données, pas besoin de preciser le cast(long)");
            Console.ReadLine();
           

        }
    }
}
