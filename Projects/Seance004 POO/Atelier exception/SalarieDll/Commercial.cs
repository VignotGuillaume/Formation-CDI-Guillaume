using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarieDll
{
    [Serializable()] public class Commercial : Salarie
    {
        #region Parametres

        decimal _chiffreAffaire;
        decimal _Commission;

        #endregion

        #region Proprietes

        public decimal ChiffreAffaire
        {
            get
            {
                return _chiffreAffaire;
            }

            set
            {
                if (isChiffreAffaireValide(value))
                {
                    _chiffreAffaire = value;
                }
                else
                {
                    _chiffreAffaire = 0;
                }
            }
        }

        public decimal Commission
        {
            get
            {
                return _Commission;
            }

            set
            {
                if (isCommissionValide(value))
                {
                    _Commission = value;
                }
                else
                {
                    _Commission = 0;
                }
            }
        }
        #endregion          

        #region Methodes

        public static bool isChiffreAffaireValide(decimal n)
        {

            if (n >= 0 && n <= 1000000)
            {
                return true;

            }
            return false;
        }





        public static bool isCommissionValide(decimal n)
        {

            if (n >= 0 && n <= 1)
            {
                return true;

            }
            return false;
        }


        public override decimal SalaireNet
        {
            get
            {

                //return ((1 - TauxCS) *SalaireBrut)+(Commission*ChiffreAffaire);
                return base.SalaireNet + (Commission * ChiffreAffaire);
            }


        }

        public override string ToString()
        {
           
            return (base.ToString() + string.Format(" {0}  ; {1}", _chiffreAffaire, _Commission));
        }

        #endregion

        #region Constructeur


        //constructeur vide

        public Commercial() 
        {

        }
        //constructeur par défaut

        public Commercial(string matricule, string nom, string prenom ,decimal chiffreAffaire, decimal commission ) : base( matricule,  nom, prenom)
        {
            //assignation des valeurs
           
            this.ChiffreAffaire = chiffreAffaire;
            this.Commission = commission;
        }

        //constructeur de recopie (propriete)(fournir au minimum matricule et nom)
        public Commercial(Commercial commercialCopie) : base(commercialCopie)
        {
            this.ChiffreAffaire = commercialCopie.ChiffreAffaire;
            this.Commission = commercialCopie.Commission;
        }


        #endregion






    }
}
