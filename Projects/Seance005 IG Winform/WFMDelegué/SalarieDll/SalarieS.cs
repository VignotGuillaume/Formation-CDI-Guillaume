using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarieDll
{
   public class SalarieS : List<Salarie>
    {
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

            } return false;
            
        }


        public Salarie Extraire(string matricule)
        {
            foreach (Salarie item in this)
            {
                if (item.Matricule==matricule)
                {
                    return item;
                }
            }  return null;

            
        }




        //methode qui supprime l element dont le matriucle est fourni
        public void Remove(string matricule)
        {
            base.Remove(Extraire(matricule));

        }

    }

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
}

 //-----------------------------------------------------------------------------------------------

        

     