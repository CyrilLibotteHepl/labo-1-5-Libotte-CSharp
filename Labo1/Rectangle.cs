using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo1
{
    public class Rectangle : Forme, ISommets
    {
        #region VARIABLE+GETSET

        protected int longueur;
        protected int largeur;

        public int longueur
        {
            get { return longueur; }
            set { longueur = value; }
        }

        public int largeur
        {
            get { return largeur; }
            set { largeur = value; }
        }
        #endregion

        #region CONSTRUCTEUR
        public Rectangle() { longueur = 0; largeur = 0; }
        public Rectangle(int lg, int lrg)
        {
            longueur = lg;
            largeur = lrg;
        }
        #endregion

        #region REDEFINITION

        public override string ToString()
        {
            return " Longueur : " + longueur + "Largeur : " + largeur + " Coordonnée : " + pointDaccroche;
        }

        public override void Affiche()
        {
            Console.WriteLine("Caractéristiques du rectangle : \n" + ToString() + "\n");
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
