using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo1
{
    public class Carre : Forme, ISommets
    {
        protected int _Cote;

        public int Cote
        {
            get { return _Cote; }
            set { _Cote = value; }
        }

        public Carre (int c)
        {
            this.cote = c;
        }

        public Carre()
        {
            this.cote = 0;
        }

        #region REDEFINITION
        public override string ToString()
        {
            return " Longueur : " + cote + " Coordonnée : " + pointDaccroche;
        }

        public override void Affiche()
        {
            Console.WriteLine("Caractéristiques du carré : \n" + ToString() + "\n");
        }
        #endregion

        #region SOMMETS
        int ISommets.NbSommet()
        {
            return 4;
        }
        #endregion
    }
}
