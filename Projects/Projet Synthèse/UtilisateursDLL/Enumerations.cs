using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalariesDll
{
    /// <summary>
    /// Connection result (enum)
    /// </summary>
    public enum ConnectionResult

    {
        /// <summary>
        /// renvoie 0
        /// </summary>
        Connecté = 0,
        
        /// <summary>
        /// renvoie 2
        /// </summary>
        MotPasseInvalide = 2,

        /// <summary>
        /// renvoie 3
        /// </summary>

        CompteBloqué = 3

    }
}
