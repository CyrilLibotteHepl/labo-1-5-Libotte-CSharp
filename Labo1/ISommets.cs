using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo1
{
    public class ISommets
    {
        public interface ISommets
        {
            //lecture seul car il n'y a qu'un get 
            #region NBSOMMETS 
            int NbSommet { get; }
            #endregion
        }
    }
}
