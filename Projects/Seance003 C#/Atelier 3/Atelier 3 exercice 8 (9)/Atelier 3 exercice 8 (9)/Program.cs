using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier_3_exercice_8__9_
{
    class Program
    {
        
            
        
        static void Main(string[] args) 
        {
            /*(10 % 3)*/
            /*division avec recuperation du reste (modulo)*/
            nombreBase();
            Console.ReadLine();
        }


        private static void nombreBase()
        {
            int nombre = 100;            
            int modulo = 0;
            int resultat = 0;
            bool boolmodulo = false;
            Console.WriteLine("Nombre de base {0} a diviser par 2", nombre );
            divisionModulo(ref nombre,ref modulo, ref boolmodulo,ref resultat);
            Console.WriteLine("nombre= {0},resultat {1},modulo={2}", nombre,resultat, modulo);
            Console.WriteLine(boolmodulo);
        }

        private static bool divisionModulo (ref int nombre,ref int modulo,ref bool boolmodulo,ref int resultat ) 
        {
            
            modulo = (nombre % 2);
            resultat = (nombre / 2);
            if (modulo==0)
            {
                boolmodulo = true;
            }
            return boolmodulo;

        }                           

    }
}
