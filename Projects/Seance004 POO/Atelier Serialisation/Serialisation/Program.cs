using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.IO;
using SalarieDll;

namespace Serialisation
{
    class Program : SalarieS
    {



        #region Exo 1
        //static void Main(string[] args)
        //{
        //    //FileStream fs = new FileStream("Exemple.txt", FileMode.Create, FileAccess.Write, FileShare.Read);
        //    //StreamReader sr = new StreamReader(fs, System.Text.Encoding.UTF8);
        //    //StreamWriter sw = new StreamWriter(fs);

        //    //string strLine1 = "un";
        //    //sw.WriteLine(strLine1);
        //    //string strLine2 = "deux";
        //    //sw.WriteLine(strLine2);
        //    //string strLine3 = "trois";
        //    //sw.WriteLine(strLine3);

        //    //sw.Close();
        //    //fs.Close();

        //    //Extraction();


        //    Console.ReadLine();

        //}


        //static void Acquisition()
        //{

        //    FileStream fs = new FileStream("Exemple.txt", FileMode.Append, FileAccess.Write, FileShare.Read);
        //    //StreamReader sr = new StreamReader(fs, System.Text.Encoding.UTF8);
        //    StreamWriter sw = new StreamWriter(fs);

        //    string strLine1 = "un";
        //    sw.WriteLine(strLine1);
        //    string strLine2 = "deux";
        //    sw.WriteLine(strLine2);
        //    string strLine3 = "trois";
        //    sw.WriteLine(strLine3);

        //    sw.Close();
        //    fs.Close();

        //}

        //static void Extraction()
        //{
        //    FileStream fs = new FileStream("Exemple.txt", FileMode.Open, FileAccess.Read);
        //    StreamReader sr = new StreamReader(fs);
        //    string strLine = sr.ReadLine();
        //    while (strLine != null)
        //    {
        //        Console.WriteLine(strLine);
        //        strLine = sr.ReadLine();

        //    }
        //    sr.Close();
        //    fs.Close();


        //}
        #endregion

        #region Exo 2



        //static SalarieS listeSalaries = new SalarieS();

        //public static void Main(string[] args)
        //{
        //    string cheminFichiertxt = @"E:\Visual Studio 2015\Projects\Serialisation\Serialisation\bin\Debug\SalariesTexte.csv";
        //    string cheminFichiertxt = @"F:\SalariesTexte.csv";
        //    string cheminFichierXml = @"E:\Visual Studio 2015\Projects\Serialisation\Serialisation\bin\Debug\Salariesxml.xml";
        //    string cheminFichierXml = @"F:\Salariesxml.xml";
        //    string cheminFichierBinary = @"E:\Visual Studio 2015\Projects\Serialisation\Serialisation\bin\Debug\SalariesBinary.dat";
        //    string cheminFichierBinary = @"F:\SalariesBinary.dat";


        //    listeSalaries.Add(new Salarie() { Matricule = "12XXX12", Nom = "bost", Prenom = "vincent" });
        //    listeSalaries.Add(new Salarie() { Matricule = "12XXX13", Nom = "henaff", Prenom = "marion" });
        //    listeSalaries.Add(new Salarie() { Matricule = "12XXX14", Nom = "tartempion", Prenom = "gilbert" });
        //    listeSalaries.Add(new Salarie() { Matricule = "12XXX15", Nom = "vignot", Prenom = "guillaume" });

        //    listeSalaries.Add(new Commercial() { Matricule = "12XXX17", Nom = "hollande", Prenom = "francois", Commission = 0.5m, ChiffreAffaire = 10000 });


        //    listeSalaries.Savetext(cheminFichiertxt);

        //    listeSalaries.SaveXml(cheminFichierXml);

        //    listeSalaries.SaveBinary(cheminFichierBinary);

        //    listeSalaries.Clear();



        //Console.ForegroundColor = ConsoleColor.Red;
        //    Console.Write(" --------------------------------------- ");
        //    Console.ForegroundColor = ConsoleColor.White;
        //    Console.ForegroundColor = ConsoleColor.Cyan;
        //    Console.Write(" Format texte ");
        //    Console.ForegroundColor = ConsoleColor.White;
        //    Console.ForegroundColor = ConsoleColor.Red;
        //    Console.WriteLine(" ------------------------------------ ");
        //    Console.ForegroundColor = ConsoleColor.White;




        //    listeSalaries.Loadtext(cheminFichiertxt);
        //    listeSalaries.Clear();



        //    Console.ForegroundColor = ConsoleColor.Red;
        //    Console.Write(" --------------------------------------- ");
        //    Console.ForegroundColor = ConsoleColor.White;
        //    Console.ForegroundColor = ConsoleColor.Cyan;
        //    Console.Write(" Format Xml ");
        //    Console.ForegroundColor = ConsoleColor.White;
        //    Console.ForegroundColor = ConsoleColor.Red;
        //    Console.WriteLine(" -----------------------------------");
        //    Console.ForegroundColor = ConsoleColor.White;




        //    listeSalaries.LoadXml(cheminFichierXml);
        //    listeSalaries.Clear();



        //    Console.ForegroundColor = ConsoleColor.Red;
        //    Console.Write(" --------------------------------------- ");
        //    Console.ForegroundColor = ConsoleColor.White;
        //    Console.ForegroundColor = ConsoleColor.Cyan;
        //    Console.Write(" Format Binary ");
        //    Console.ForegroundColor = ConsoleColor.White;
        //    Console.ForegroundColor = ConsoleColor.Red;
        //    Console.WriteLine(" -----------------------------------");
        //    Console.ForegroundColor = ConsoleColor.White;




        //    listeSalaries.LoadBinary(cheminFichierBinary);
        //    listeSalaries.Clear();



        //    Console.ForegroundColor = ConsoleColor.Red;
        //    Console.WriteLine("_");
        //    Console.Write(" --------------------------------------- ");
        //    Console.ForegroundColor = ConsoleColor.White;
        //    Console.ForegroundColor = ConsoleColor.Cyan;
        //    Console.Write(" FIN ");
        //    Console.ForegroundColor = ConsoleColor.White;
        //    Console.ForegroundColor = ConsoleColor.Red;
        //    Console.WriteLine(" ----------------------------------- ");
        //    Console.ForegroundColor = ConsoleColor.White;

        //    Console.ReadLine();

        //}














        #endregion

        #region Exo 3
        static SalarieS listeSalaries = new SalarieS();

        public static void Main(string[] args)
        {
            string cheminFichiertxt = @"E:\Visual Studio 2015\Projects\Serialisation\Serialisation\bin\Debug\SalariesTexte.csv";
            //string cheminFichiertxt = @"F:\SalariesTexte.csv";
            string cheminFichierXml = @"E:\Visual Studio 2015\Projects\Serialisation\Serialisation\bin\Debug\Salariesxml.xml";
            //string cheminFichierXml = @"F:\Salariesxml.xml";
            string cheminFichierBinary = @"E:\Visual Studio 2015\Projects\Serialisation\Serialisation\bin\Debug\SalariesBinary.dat";
            //string cheminFichierBinary = @"F:\SalariesBinary.dat";


            listeSalaries.Add(new Salarie() { Matricule = "12XXX12", Nom = "bost", Prenom = "vincent" });
            listeSalaries.Add(new Salarie() { Matricule = "12XXX13", Nom = "henaff", Prenom = "marion" });
            listeSalaries.Add(new Salarie() { Matricule = "12XXX14", Nom = "tartempion", Prenom = "gilbert" });
            listeSalaries.Add(new Salarie() { Matricule = "12XXX15", Nom = "vignot", Prenom = "guillaume" });

            listeSalaries.Add(new Commercial() { Matricule = "12XXX17", Nom = "hollande", Prenom = "francois", Commission = 0.5m, ChiffreAffaire = 10000 });



            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Que souhaitez vous faire?");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("S pour serialisation");
            Console.WriteLine("D pour deserialisation");
            Console.WriteLine("R pour recherche par matricule");
            Console.WriteLine("E pour effacer par matricule");
            Console.WriteLine("M pour modification");
            Console.WriteLine("F pour sortir du programme");
            Console.ForegroundColor = ConsoleColor.White;

            string reponse = Console.ReadLine();
            switch (reponse)
            {
                case "S":
                    listeSalaries.Savetext(cheminFichiertxt);
                    listeSalaries.SaveXml(cheminFichierXml);
                    listeSalaries.SaveBinary(cheminFichierBinary);
                    listeSalaries.Clear();
                    Console.WriteLine("Serialisation effectuee");
                    break;
                case "D":
                    #region case"D"
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" --------------------------------------- ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(" Format texte ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" ------------------------------------ ");
                    Console.ForegroundColor = ConsoleColor.White;




                    listeSalaries.Loadtext(cheminFichiertxt);
                    listeSalaries.Clear();



                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" --------------------------------------- ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(" Format Xml ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" -----------------------------------");
                    Console.ForegroundColor = ConsoleColor.White;




                    listeSalaries.LoadXml(cheminFichierXml);
                    listeSalaries.Clear();



                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" --------------------------------------- ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(" Format Binary ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" -----------------------------------");
                    Console.ForegroundColor = ConsoleColor.White;




                    listeSalaries.LoadBinary(cheminFichierBinary);
                    listeSalaries.Clear();



                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.Write(" \n --------------------------------------- ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(" FIN ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" ----------------------------------- ");
                    Console.ForegroundColor = ConsoleColor.White;

                    #endregion
                    break;
                case "R":
                    Console.WriteLine("Saisissez le matricule du salarie recherché");
                    string matriculeARechercher = Console.ReadLine();
                    Salarie resultat = listeSalaries.recherche(matriculeARechercher);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(resultat);
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "E":
                    #region case E


                    Console.WriteLine("Saisissez le matricule du salarie a effacer");
                    string matriculeAEffacer = Console.ReadLine();
                    listeSalaries.effacement(matriculeAEffacer);
                    listeSalaries.Savetext(cheminFichiertxt);
                    listeSalaries.SaveXml(cheminFichierXml);
                    listeSalaries.SaveBinary(cheminFichierBinary);
                    listeSalaries.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" --------------------------------------- ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(" Format texte ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" ------------------------------------ ");
                    Console.ForegroundColor = ConsoleColor.White;




                    listeSalaries.Loadtext(cheminFichiertxt);
                    listeSalaries.Clear();



                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" --------------------------------------- ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(" Format Xml ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" -----------------------------------");
                    Console.ForegroundColor = ConsoleColor.White;




                    listeSalaries.LoadXml(cheminFichierXml);
                    listeSalaries.Clear();



                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" --------------------------------------- ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(" Format Binary ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" -----------------------------------");
                    Console.ForegroundColor = ConsoleColor.White;




                    listeSalaries.LoadBinary(cheminFichierBinary);
                    listeSalaries.Clear();



                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.Write("\n--------------------------------------- ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(" FIN ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" ----------------------------------- ");
                    Console.ForegroundColor = ConsoleColor.White;


                    //reset
                    //listeSalaries.Savetext(cheminFichiertxt);
                    //listeSalaries.SaveXml(cheminFichierXml);
                    //listeSalaries.SaveBinary(cheminFichierBinary);
                    //listeSalaries.Clear();


                    #endregion


                    break;
            }



            Console.ReadLine();



        }



        #endregion




    }
}
