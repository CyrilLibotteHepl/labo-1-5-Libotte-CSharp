using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathUtil;

namespace MaLibrairieForme
{
    public class Rectangle : Forme, ISommets
    {
        protected int _Longueur;
        protected int _Largeur;

        public int Longueur
        {
            get { return _Longueur; }
            set { _Longueur = value; }
        }

        public int Largeur
        {
            get { return _Largeur; }
            set { _Largeur = value; }
        }

        public Rectangle(Coordonnees p) : base(p)
        {
            _Longueur = 0;
            _Largeur = 0;
        }

        public Rectangle(int Lenght, int Width, Coordonnees p) : base(p)
        {
            _Longueur = Lenght;
            _Largeur = Width;
        }

        public override string ToString()
        {
            return "Longueur du rectangle : " + _Longueur + " Largeur du rectangle : " + _Largeur + " Coordonnées du rectangle : " + _C;
        }

        public override void Affiche()
        {
            Console.WriteLine("\n" + ToString() + "\n");
        }

        public override bool CoordonneeEstDans(Coordonnees p)
        {
            if (_C.X <= p.X && (_C.X + _Longueur) >= p.X)
            {
                if (_C.Y >= p.Y && (_C.Y - _Largeur) <= p.Y) { return true; }
            }
            return false;
        }

        public int NbSommets
        {
            get { return 4; }
        }
    }
}
