using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathUtil;

namespace MaLibrairieForme
{
    public class Carre : Forme, ISommets, IComparable<Carre>
    {
        protected int _Cote;

        public int Cote
        {
            get { return _Cote; }
            set { _Cote = value; }
        }

        public Carre(Coordonnees p) : base (p)
        {
            _Cote = 0;
        }
        public Carre(int lc, Coordonnees p) : base(p)
        {
            _Cote = lc;
        }

        public override string ToString()
        {
            return "Longueur du côté du carré : " + _Cote + " Coordonnées du carré : " + _C;
        }
        public override void Affiche()
        { Console.WriteLine("\n" + ToString() + "\n"); }

        public override bool CoordonneeEstDans(Coordonnees p)
        {
            if (_C.X <= p.X && (_C.X + _Cote) >= p.X)
            {
                if (_C.Y >= p.Y && (_C.Y - _Cote) <= p.Y) { return true; }
            }
            return false;
        }

        public int NbSommets
        {
            get { return 4; }
        }

        public int CompareTo(Carre other)
        {
            return _Cote.CompareTo(other._Cote);
        }
    }
}
