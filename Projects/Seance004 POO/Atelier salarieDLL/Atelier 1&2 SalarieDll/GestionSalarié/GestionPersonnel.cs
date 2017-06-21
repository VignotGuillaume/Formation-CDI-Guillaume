using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalarieDll;

namespace GestionSalarié
{
    class GestionPersonnel
    {
        static void Main(string[] args)
        {
            #region Initialisation

            
            Salarie salarie1 = new Salarie();
            //Salarie salarie2 = salarie1;
            #endregion

            #region Test
            //test pour valeurs correctes
            salarie1.Matricule = "12abc67";
            salarie1.Nom = "vignot";
            salarie1.Prenom = "guillaume";
            salarie1.SalaireBrut = 1700;
            salarie1.TauxCS = 0.21m;
            salarie1.DateNaissance = new DateTime(1985, 07, 13);


            //test pour valeurs incorrectes(premier test)
            //salarie1.Matricule = "12a6c67";
            //salarie1.Nom = "vignot1";
            //salarie1.Prenom = "0";
            //salarie1.SalaireBrut = 1700a;
            //salarie1.TauxCS = 0.7m;
            //salarie1.DateNaissance = new DateTime(1285, 07, 13);

            //test pour valeurs incorrectes(deuxieme test)
            //salarie1.Matricule = "0";
            //salarie1.Nom = "";
            //salarie1.Prenom = "ab";
            //salarie1.SalaireBrut = 0;
            //salarie1.TauxCS = 0.9m;
            //salarie1.DateNaissance = new DateTime(1285, 07, 13);


            //test pour valeurs incorrectes(deuxieme test)
            //salarie1.Matricule = "";
            //salarie1.Nom = "";
            //salarie1.Prenom = "ab";
            //salarie1.SalaireBrut = 0;
            //salarie1.TauxCS = 0.9m;
            //salarie1.DateNaissance = new DateTime(2010, 07, 13);
            #endregion

            #region Salarie 1
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" --------------------------------------- ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(" SALARIE 1 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" -------------------------------------------------------------- ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Info complete du salarié 1");
            Console.WriteLine(" Nom: {0}\n Prenom: {1}\n Date de naissance: {2}\n Age: {3} ans \n Matricule: {4}\n Salaire Brut: {5} euros \n Taux des charges: {6} % \n Salaire net: {7} euros " , salarie1.Nom, salarie1.Prenom, salarie1.DateNaissance, salarie1.Age, salarie1.Matricule, salarie1.SalaireBrut, (salarie1.TauxCS * 100) , salarie1.SalaireNet);
            
            Console.WriteLine(salarie1.ToString());
            
            Console.WriteLine("HashCode = {0} ", salarie1.GetHashCode());
            

            #endregion

            #region Salarie 2
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" --------------------------------------- ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(" SALARIE 2 "); 
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" -------------------------------------------------------------- ");
            Console.ForegroundColor = ConsoleColor.White;

            
            Console.WriteLine("Info  du salarié 2 copié du 1");
            Salarie salarie2 = new Salarie(salarie1);
            Console.WriteLine(salarie2.Nom);
            
            Console.WriteLine(salarie2.ToString());
            
            

            #endregion

            #region Salarie 3

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" --------------------------------------- ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(" SALARIE 3 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" -------------------------------------------------------------- ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Info  du salarie3 copié du 1 avec modif (nom, prenom ,matricule)");
            Salarie salarie3 = new Salarie(salarie1) { Nom = "salarie", Prenom = "quatre", Matricule = "11xxx22" };
            Console.WriteLine(salarie3.Nom);
            Console.WriteLine(salarie3.Prenom);
            Console.WriteLine(salarie3.Matricule);
            
            Console.WriteLine(salarie3.ToString());
            
            
                       
            
            #endregion

            #region Salarie 4
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" --------------------------------------- ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(" SALARIE 4 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" -------------------------------------------------------------- ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Info  du salarié 4  (identique au 5 pour test hash) ");
            Salarie salarie4 = new Salarie("12abc67", "pierre");          
                        
            Console.WriteLine(salarie4.ToString());
            
            Console.WriteLine("HashCode du nom du salarie 4 = {0} ", salarie4.Nom.GetHashCode());
            Console.WriteLine("HashCode du matricule du salarie 4 = {0} ", salarie4.Matricule.GetHashCode());
            Console.WriteLine("HashCode du salarie 4 (complet) = {0} ", salarie4.GetHashCode());
                        
            
            #endregion

            #region Salarie 5
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" --------------------------------------- ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(" SALARIE 5 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" -------------------------------------------------------------- ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Info  du salarié 5 (identique au 4 pour test hash) ");
            Salarie salarie5 = new Salarie("12abc67", "pierre");
            Console.WriteLine("nom {0}", salarie5.Nom);
            
            Console.WriteLine(salarie5.ToString());
            
            Console.WriteLine("HashCode du nom du salarie 5 = {0} ", salarie5.Nom.GetHashCode());
            Console.WriteLine("HashCode du matricule du salarie 5 = {0} ", salarie5.Matricule.GetHashCode());
            Console.WriteLine("HashCode du salarie 5 (complet) = {0} ",salarie5.GetHashCode());
                  
            
            #endregion
             
            #region Test du equals sur salarie 4 et salarie 5
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" --------------------------------------- ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(" EQUALS ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" -------------------------------------------------------------- ");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Test du equals");
            Console.WriteLine("salarie 4 equals  salarie 5 : {0} ",salarie4.Equals(salarie5));
            
            
            #endregion

            #region Affichage instance
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" --------------------------------------- ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(" INSTANCE  ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" -------------------------------------------------------------- ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Nombre d'instances:{0}", Salarie.CompteurInstances);


            #endregion

            #region Commercial1
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" --------------------------------------- ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(" COMMERCIAL 1  ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" -------------------------------------------------------------- ");
            Console.ForegroundColor = ConsoleColor.White;
            

            Commercial commercial1 = new Commercial(100000, 0.5m);
            commercial1.SalaireBrut = 500;
            commercial1.TauxCS = 0.5m;
            commercial1.Nom = "vignot";
            commercial1.Prenom = "guillaume";
            commercial1.Matricule = "12abc67";
            
            
            Console.WriteLine(commercial1.ToString());
            
            Console.WriteLine("HashCode du nom du commercial1 = {0} ", commercial1.Nom.GetHashCode());
            Console.WriteLine("HashCode du matricule du commercial1 = {0} ", commercial1.Matricule.GetHashCode());
            Console.WriteLine("HashCode du commercial1 (complet) = {0} ", commercial1.GetHashCode());
            Console.WriteLine("COMMERCIAL 1: chiffre d'affaire: {0} puis commission: {1} puis (salaire net +commission) du commercial1:  {2} ", commercial1.ChiffreAffaire, commercial1.Commission, commercial1.SalaireNet);
           
            
            #endregion

            #region Commercial2
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" --------------------------------------- ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(" COMMERCIAL 2 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" -------------------------------------------------------------- ");
            Console.ForegroundColor = ConsoleColor.White;
            
            Commercial commercial2 = new Commercial(commercial1);
            Console.WriteLine(commercial2.ToString());
            Console.WriteLine("HashCode du nom du commercial1 = {0} ", commercial1.Nom.GetHashCode());
            Console.WriteLine("HashCode du matricule du commercial1 = {0} ", commercial1.Matricule.GetHashCode());
            Console.WriteLine("HashCode du commercial1 (complet) = {0} ", commercial1.GetHashCode());
            Console.WriteLine("COMMERCIAL 2: chiffre d'affaire: {0} puis commission: {1} puis (salaire net +commission) du commercial1:  {2} ", commercial1.ChiffreAffaire, commercial1.Commission, commercial1.SalaireNet);
            
            
            #endregion

            #region test du equals sur commercial 1 et commercial 2
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" --------------------------------------- ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("  EQUALS  ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" -------------------------------------------------------------- ");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Test du equals");
            Console.WriteLine("commercial 1 equals  commercial 2 : {0} ", commercial1.Equals(commercial2));            
            

            #endregion

            

            #region Affichage instance
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" --------------------------------------- ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(" INSTANCE ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" -------------------------------------------------------------- ");
            Console.ForegroundColor = ConsoleColor.White;


            Console.WriteLine("Nombre d'instances:{0}", Salarie.CompteurInstances);


            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" --------------------------------------- ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(" FIN ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" -------------------------------------------------------------- ");
            Console.ForegroundColor = ConsoleColor.White;
            #endregion

            Console.ReadLine();
        }

        




    }
}
