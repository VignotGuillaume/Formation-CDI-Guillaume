using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;

namespace Stagiaires
{
    public class Stagiaire
    {
        string _nom = string.Empty;
        DateTime _dateNaissance;

        public string Nom
        {
            get { return _nom; }

            set
            {
                if (isNomValide(value))
                {
                    _nom = value;
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
        public DateTime DateNaissance
        {
            get { return _dateNaissance; }

            set { _dateNaissance = value; }
            
        }

        public static bool isNomValide(string n)
        {
            foreach (char item in n)
            {
                if (!char.IsLetter(item)) return false;
            }
            
            return true;
        }
    }
}
