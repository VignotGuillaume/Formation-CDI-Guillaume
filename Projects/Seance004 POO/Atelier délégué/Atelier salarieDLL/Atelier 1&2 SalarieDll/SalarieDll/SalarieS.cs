using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarieDll
{
    class SalarieS : List<Salarie>
    {
        public new void Add(Salarie nouveauSalarie)
        {
            foreach (var item in this)
            {
                if (!Equals(nouveauSalarie))
                {
                 
                }      

            }

        }

        

    }
}

 //-----------------------------------------------------------------------------------------------

        

     