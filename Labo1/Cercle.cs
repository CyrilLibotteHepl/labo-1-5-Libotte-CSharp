using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo1
{
    public abstract class Cercle : Forme
    {
        #region CARACDIAMETRE
        protected int Diametre;
        public int Diametre
        {
            get { return Diametre; }
            set { Diametre= value; }
        }
        #endregion

        #region CONSTRUCTEUR
        public Cercle(int diametre)
        {
            Diametre = diametre;
        }
        public Cercle()
        {
            Diametre = 0;
        }
        #endregion

        public override string ToString()
        {
            return "Diametre de cercle : " + Diametre + " et coordonnée : " + pointDaccroche;
        }

        public override int Affiche() { Console.WriteLine("Caractéristiques du cercle :  \n" + ToString() + "\n"); }
    }
}
