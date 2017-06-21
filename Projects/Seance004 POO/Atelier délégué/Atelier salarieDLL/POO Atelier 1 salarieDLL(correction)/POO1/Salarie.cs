using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Poo1
{
    /// <summary>
    /// Type Salarie
    /// </summary>

    public class Salarie
    {
        #region Champs privés

        private static int _nombreInstances;
        private string _matricule;
        private string _nom = string.Empty;
        private string _prenom = string.Empty;
        private decimal _salaireBrut;
        private decimal _tauxCS;
        private DateTime _dateNaissance;
        #endregion

        #region Propriétés
        /// <summary>
        /// Nombres d'instances
        /// </summary>
        public static int NombreInstances
        {
            get {
                
                
                  return Salarie._nombreInstances; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Matricule
        {
            get { return (this._matricule); }
            set
            {
                if (!IsMatriculeValide(value)) throw new ApplicationException("Matricule invalide");
                this._matricule = value;
            }
        }
        /// <summary>
        /// Nom du salarié
        /// Longueur comprise entre 3 et 30 caractères. Ni caractères spéciaux ni chiffres 
        /// </summary>
        public string Nom
        {
            get { return (this._nom); }
            set
            {
                if (!IsNomPrenomValide(value)) throw new ApplicationException(string.Format(CultureInfo.CurrentCulture, "Le nom {0} n'est pas valide.", value)); ;
                this._nom = string.Format(CultureInfo.CurrentCulture, "{0}{1}", value.Trim().Substring(0, 1).ToUpper(CultureInfo.CurrentCulture), value.Trim().Substring(1, value.Trim().Length - 1).ToLower(CultureInfo.CurrentCulture));
            }
        }
        /// <summary>
        /// Prenom 
        /// </summary>
        public string Prenom
        {
            get { return (this._prenom); }
            set
            {
                if (!IsNomPrenomValide(value)) throw new ApplicationException(string.Format(CultureInfo.CurrentCulture, "Le prénom {0} n'est pas valide.", value)); ;
                this._prenom = string.Format(CultureInfo.CurrentCulture, "{0}{1}", value.Trim().Substring(0, 1).ToUpper(CultureInfo.CurrentCulture), value.Trim().Substring(1, value.Trim().Length - 1).ToLower(CultureInfo.CurrentCulture));
            }
        }
        /// <summary>
        /// Salaire brut
        /// </summary>
        public decimal SalaireBrut
        {
            get { return (this._salaireBrut); }
            set
            {
                this._salaireBrut = value;
               
            }

        }
        /// <summary>
        /// Taux de charges sociales affecté
        /// Ne peut excéder 0.6
        /// </summary>
        public decimal TauxCS
        {
            get { return (this._tauxCS); }
            set
            {
                if ((value < 0) || (value > 0.6m))
                {
                    throw new Exception(string.Format(CultureInfo.CurrentCulture, "Le taux {0} n'est pas acceptable.", value));

                }

                else
                {
                    this._tauxCS = value;
                }
            }
        }
        /// <summary>
        /// Date de naissance
        /// Ne peut être antérieure au 1er janvier 1900 et postérieure à J -15 ans
        /// </summary>
        public DateTime DateNaissance
        {
            get { return (this._dateNaissance); }
            set
            {
                if (value.CompareTo(new DateTime(1900, 01, 01)) < 0) throw new Exception(String.Format(CultureInfo.CurrentCulture, "La Date de naissance {0:d} ne peut être antérieure au 1 janvier 1900", value));
                if (value.CompareTo(DateTime.Today.AddYears(-15)) > 0) throw new Exception(String.Format(CultureInfo.CurrentCulture, "La Date de naissance {0:d} ne peut être postérieure au {1:d}", value, DateTime.Today.AddYears(-15)));
                else this._dateNaissance = value;
            }
        }

        /// <summary>
        /// Salaire touché par le salarie apres déduction des charges sociales
        /// </summary>
        public virtual decimal SalaireNet
        {
            get { return this._salaireBrut * (1 - this._tauxCS); }
        }

        #endregion

        #region Méthodes 

        /// <summary>
        /// Verification de la conformite de la saisie pour les noms et prenoms.
        /// Longueur comprise entre 3 et 30 caractères
        /// Uniquement composé de lettres
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        ///
        public static bool IsNomPrenomValide(string value)
        {
            if (value == null || value.Trim().Length < 3 || value.Trim().Length > 30 ) return false;

            foreach (char caractere in value)
            {
                if (!char.IsLetter(caractere)) return false;
            }
            return true;

        }
        /// <summary>
        /// Vérifie que le matricule respecte les règles suivantes
        /// Longueur 7 structure nnXXXnnn ou n est un digit et X une lettre
        /// </summary>
        /// <param name="value">La valeur du matricule</param>
        /// <returns></returns>
        public static bool IsMatriculeValide(string value)
        {
            if (value== null || value.Length != 7) return false;
            for (int i = 0; i < value.Length; i++)
            {
                if ((i < 2 || i > 4) && !char.IsNumber(value[i])) return false;
                if ((i > 2 && i < 5) && !char.IsLetter(value[i])) return false;
            }
            return true;
        }
        #endregion
        #region Constructeurs
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Salarie()
        {
            _nombreInstances++;
        }

        /// <summary>
        /// Constructeur de recopie
        /// </summary>
        /// <param name="salarie"></param>
        public Salarie(Salarie salarie)
            : this(salarie.Nom,salarie.Prenom,salarie.Matricule)
        {
            if (salarie != null)
            {
                
                this.SalaireBrut = salarie.SalaireBrut;
                this.TauxCS = salarie.TauxCS;
                this.DateNaissance = salarie.DateNaissance;
            }
        }
        /// <summary>
        /// Constructeur d'initialisation partielle
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="matricule"></param>
        public Salarie(string nom, string prenom, string matricule)
            : this()
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Matricule = matricule;

        }

        #endregion
        #region Destructeur
        /// <summary>
        /// Destructeur pour tests
        /// </summary>
        ~Salarie()
        {
            _nombreInstances--;

        }
        #endregion


    }

}

