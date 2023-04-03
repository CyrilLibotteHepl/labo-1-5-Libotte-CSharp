using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaLibrairieForme
{
    public class Coordonnees
    {
        protected int _X;
        protected int _Y;

        public int X
        {
            get { return _X; }
            set { _X = value; }
        }

        public int Y
        {
            get { return _Y; }
            set { _Y = value; }
        }

        //constructeur obligé d'avoir une liste de paramètre
        public Coordonnees() : this(0, 0) //appel du constructeur d'initialisation pour le par défaut
        {

        }

        public Coordonnees(int x, int y)
        {
            _X = x;
            _Y = y;
        }

        public override string ToString()
        {
            return "(" + _X + ", " + _Y + ")";
        }

        public void Affiche()
        {
            Console.WriteLine("\nCoordonnées : " + ToString() + "\n");
        }

    }
}
