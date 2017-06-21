using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Xml;

namespace SalarieDll
{
    [Serializable()]
    [XmlInclude(typeof(Commercial))]
    public class SalarieS : List<Salarie>
    {
        #region methodes
        public new void Add(Salarie salarie)
        {
            //if (!IfExists(salarie))
            //{
            //    base.Add(salarie);
            //}

            if (!Contains(salarie))
            {
                base.Add(salarie);
            }

        }

        private bool IfExists(Salarie sal)
        {
            foreach (Salarie item in this)
            {
                if (item.Equals(sal))
                {
                    return true;
                }

            }
            return false;

        }


        public Salarie Extraire(string matricule)
        {
            foreach (Salarie item in this)
            {
                if (item.Matricule == matricule)
                {
                    return item;
                }
            }
            return null;


        }




        //methode qui supprime l element dont le matriucle est fourni
        public void Remove(string matricule)
        {
            base.Remove(Extraire(matricule));

        }

        #endregion



        #region Save 


        public void Savetext(string fichier)
        {

            FileStream fs = new FileStream(fichier, FileMode.Create, FileAccess.Write, FileShare.Read);
            using (StreamWriter sw = new StreamWriter(fs))
            {
                foreach (Salarie item in this)
                {
                    sw.WriteLine(item.ToString());
                }


                sw.Close();
                fs.Close();
            }

        }



        public void SaveBinary(string fichier)
        {

            FileStream fs = new FileStream(fichier, FileMode.Create, FileAccess.Write, FileShare.Read);

            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, this);

            fs.Close();
        }

        public void SaveXml(string fichier)
        {

            FileStream fs = new FileStream(fichier, FileMode.Create, FileAccess.Write, FileShare.Read);
            XmlTextWriter xmlTW = new XmlTextWriter(fs, Encoding.UTF8);
            XmlSerializer xmlS = new XmlSerializer(this.GetType());
            xmlS.Serialize(xmlTW, this);

            fs.Close();


        }




        #endregion

        #region Load

        public void Loadtext(string fichier)
        {
            FileStream fs = new FileStream(fichier, FileMode.Open, FileAccess.Read);
            using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))
            {
                string strLine = sr.ReadLine();


                while (strLine != null)
                {
                    string[] tabSplité = strLine.Split(';');
                    Salarie salarieConverti = new Salarie();
                    salarieConverti.Nom = tabSplité[0];
                    salarieConverti.Prenom = tabSplité[1];
                    salarieConverti.DateNaissance = DateTime.Parse(tabSplité[2]);
                    salarieConverti.Matricule = tabSplité[3];
                    salarieConverti.SalaireBrut = Decimal.Parse(tabSplité[4]);
                    salarieConverti.TauxCS = Decimal.Parse(tabSplité[5]);
                    Commercial commercialConverti = new Commercial();
                    //commercialConverti.Nom = tabSplité[0];
                    //commercialConverti.Prenom = tabSplité[1];
                    //commercialConverti.DateNaissance = DateTime.Parse(tabSplité[2]);
                    //commercialConverti.Matricule = tabSplité[3];
                    //commercialConverti.SalaireBrut = Decimal.Parse(tabSplité[4]);
                    //commercialConverti.TauxCS = Decimal.Parse(tabSplité[5]);
                    //commercialConverti.ChiffreAffaire = Decimal.Parse(tabSplité[7]);
                    //commercialConverti.Commission = Decimal.Parse(tabSplité[8]);
                    //this.Add(commercialConverti);

                    this.Add(salarieConverti);

                    Console.WriteLine(strLine);
                    strLine = sr.ReadLine();

                }



                sr.Close();
                fs.Close();
            }
        }


        public void LoadBinary(string fichier)
        {
            FileStream fs = new FileStream(fichier, FileMode.Open, FileAccess.Read, FileShare.Read);
            BinaryFormatter bf = new BinaryFormatter();
            this.AddRange(bf.Deserialize(fs) as SalarieS);
            
            fs.Close();


            foreach (var item in this)
            {
                Console.WriteLine(item);
            }

        }


        public void LoadXml(string fichier)
        {
            FileStream fs = new FileStream(fichier, FileMode.Open, FileAccess.Read);
            XmlTextReader xmlTR = new XmlTextReader(fs);
            XmlSerializer xmlS = new XmlSerializer(this.GetType());
            base.AddRange(xmlS.Deserialize(xmlTR) as SalarieS);

            fs.Close();

            foreach (var item in this)
            {
                Console.WriteLine(item);
            }

        }

        #endregion

        public Salarie recherche(string matriculeSaisi)
        {
            foreach (var item in this)
            {
                if (item.Matricule == matriculeSaisi)
                {
                    return item;

                }
            }
            return null;

        }

        public void effacement(string matriculeSaisi)
        {
            this.Remove(recherche(matriculeSaisi));
        }

    }




    //-----------------------------------------------------------------------------------------------

    #region salarie hashset
    public class SalariesHS : HashSet<Salarie>
    {



        public Salarie Extraire(string matricule)
        {
            foreach (Salarie item in this)
            {
                if (item.Matricule == matricule)
                {
                    return item;
                }
            }
            return null;


        }




        //methode qui supprime l element dont le matriucle est fourni
        public void Remove(string matricule)
        {
            base.Remove(Extraire(matricule));

        }
    }

    #endregion

}






