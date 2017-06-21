using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarieDll
{

    public class Salarie
    {
        #region Parametres


        string _matricule = string.Empty;
        string _nom = string.Empty;
        string _prenom = string.Empty;
        decimal _salaireBrut;
        decimal _tauxCS;
        DateTime _dateNaissance;
        static int _compteurInstances = 0;
        #endregion

        #region Propriete

        public string Matricule
        {
            get
            {
                return _matricule;
            }

            set
            {
                if (isMatriculeValide(value))   //verif format matricule avec un BOOL
                {
                    _matricule = value;
                }
                else
                {
                    _matricule = "erreur";
                }


            }
        }

        public string Nom
        {
            get
            {
                return _nom;
            }

            set
            {
                if (isNomValide(value))
                {
                    _nom = value;
                }
                else
                {
                    _nom = "erreur";
                }

            }
        }

        public string Prenom
        {
            get
            {
                return _prenom;
            }

            set
            {
                if (isNomValide(value))
                {
                    _prenom = value;
                }
                else
                {
                    _prenom = "erreur";
                }

            }
        }

        public virtual decimal SalaireBrut
        {
            get
            {
                return _salaireBrut;
            }

            set
            {
                if (isSalaireValide(value))
                {
                    _salaireBrut = value;
                }
                else
                {
                    _salaireBrut = 0;
                }

            }
        }

        public virtual decimal SalaireNet
        {

            get
            {
                return (1 - _tauxCS) * _salaireBrut;
            }


        }

        public virtual decimal TauxCS
        {
            get
            {
                return _tauxCS;
            }

            set
            {
                if (isTauxValide(value))
                {
                    _tauxCS = value;
                }
                else
                {
                    _tauxCS = 0;
                }

            }
        }

        public DateTime DateNaissance
        {
            get
            {
                return _dateNaissance;
            }

            set
            {
                if (isDateNaissanceValide(value))
                {
                    _dateNaissance = value;
                }
                else
                {
                    _dateNaissance = DateTime.Now;
                }

            }
        }

        public int Age
        {
            get
            {
                return DateTime.Now.Subtract(_dateNaissance).Days / 365;
            }
        }

        #endregion

        #region Methodes


        public static bool isMatriculeValide(string n)
        {
            int longueur = n.Length;
            if (longueur == 7)
            {
                if (char.IsDigit(n, 0)
                    && char.IsDigit(n, 1)
                    && char.IsLetter(n, 2)
                    && char.IsLetter(n, 3)
                    && char.IsLetter(n, 4)
                    && char.IsDigit(n, 5)
                    && char.IsDigit(n, 6))
                {



                    return true;
                }

                return false;
            }
            return false;
        }


        public static bool isNomValide(string n)
        {
            int longueur = n.Length;
            if (longueur >= 3 && longueur <= 30)
            {
                foreach (char item in n)
                {
                    if (!char.IsLetter(item))
                    {
                        return false;
                    }

                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool isSalaireValide(decimal n)
        {

            if (n >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }



        }

        public static bool isTauxValide(decimal n)
        {

            if (n >= 0 && n <= 0.6m)
            {
                return true;

            }
            return false;
        }

        public static bool isDateNaissanceValide(DateTime n)
        {

            if (n.Year > 1900 && DateTime.Compare(n, DateTime.Now.AddYears(-15)) < 0)
            {
                return true;

            }
            return false;
        }

        #endregion

        #region Methodes Equals() & ToString() & Hashcode()

        public override bool Equals(object obj)
        {
            Salarie salarieEQ = obj as Salarie;

            if (salarieEQ == null)
            {
                return false;
            }
            if (_matricule.GetHashCode() == salarieEQ._matricule.GetHashCode())

            {
                return true;
            }
            else
            {
                return false;
            }

        }




        public override int GetHashCode()
        {
            //return (this.Age.GetHashCode() + this.DateNaissance.GetHashCode().etc.....).GetHashCode();     //pour des hashcode salarie egaux si les parametre, sont egaux.
            return base.GetHashCode(); //Pour des hashcode salarie differents mm si les parametre sont le mm (Id caché different)

        }


        public override string ToString()
        {
            return string.Format("Nom: {0}  ; Prenom: {1}  ; Date de naissance: {2}  ; Matricule: {3}  ; Salaire brut: {4} ; TauxCS: {5} ", _nom, _prenom, _dateNaissance, _matricule, _salaireBrut, _tauxCS);
        }

        #endregion

        #region Constructeur

        //constructeur par défaut
        public  Salarie()
        {               
            _compteurInstances++;
        }

        //constructeur de recopie (propriete)(fournir au minimum matricule et nom)

        public  Salarie(Salarie salarieCopie) : this(salarieCopie.Matricule, salarieCopie.Nom)
        {
            this.Prenom = salarieCopie.Prenom;
            this.SalaireBrut = salarieCopie.SalaireBrut;
            this.TauxCS = salarieCopie.TauxCS;
            this.DateNaissance = salarieCopie.DateNaissance;
        }

        //constructeur de recopie (champ local)(fournir au minimum mtricule et nom)
        public Salarie(string Matricule, string Nom) : this()
        {
            this.Matricule = Matricule;
            this.Nom = Nom;

        }

        #endregion

        #region Compteur d'instance

        //Compteur d'instance

        public static int CompteurInstances
        {
            get
            {
                return _compteurInstances;
            }


        }

        #endregion

    }

   



}




