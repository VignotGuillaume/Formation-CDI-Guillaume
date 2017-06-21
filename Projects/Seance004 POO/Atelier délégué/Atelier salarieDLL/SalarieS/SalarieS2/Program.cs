using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalarieDll;


namespace Collection
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    SalarieS listeSalaries=new SalarieS();

        //    listeSalaries.Add(new Salarie() { Matricule = "12XXX12",Nom = "bost", Prenom = "vincent" });
        //    listeSalaries.Add(new Salarie() { Matricule = "12XXX13", Nom = "tartempion", Prenom = "gilbert" });
        //    listeSalaries.Add(new Salarie() { Matricule = "12XXX12", Nom = "bost", Prenom = "vincent" });
        //    Console.WriteLine("Attendu true {0}", 2 == listeSalaries.Count);
        //    Salarie salASupprimmer = listeSalaries.Extraire("12XXX13");
        //    listeSalaries.Remove(salASupprimmer);
        //    Console.WriteLine("Attendu true {0}", 1 == listeSalaries.Count);
        //    listeSalaries.Remove("12XXX12");
        //    Console.WriteLine("Attendu true {0}", 0 == listeSalaries.Count);
        //    Console.ReadLine();
        //}

        static void Main(string[] args)
        {
            SalariesHS listeSalaries = new SalariesHS();

            listeSalaries.Add(new Salarie() { Matricule = "12XXX12", Nom = "bost", Prenom = "vincent" });
            listeSalaries.Add(new Salarie() { Matricule = "12XXX13", Nom = "tartempion", Prenom = "gilbert" });
            listeSalaries.Add(new Salarie() { Matricule = "12XXX12", Nom = "bost", Prenom = "vincent" });
            Console.WriteLine("Attendu true {0}", 2 == listeSalaries.Count);
            Salarie salASupprimmer = listeSalaries.Extraire("12XXX13");
            listeSalaries.Remove(salASupprimmer);
            Console.WriteLine("Attendu true {0}", 1 == listeSalaries.Count);
            listeSalaries.Remove("12XXX12");
            Console.WriteLine("Attendu true {0}", 0 == listeSalaries.Count);
            Console.ReadLine();
        }
    }
}
