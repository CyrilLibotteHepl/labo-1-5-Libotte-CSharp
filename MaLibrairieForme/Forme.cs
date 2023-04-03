using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathUtil;

namespace MaLibrairieForme
{
    public abstract class Forme : IEstDans
    {
        public Coordonnees _C;

        public Coordonnees C
        {
            get { return _C; }
            set { _C = value; }
        }

        public Forme(Coordonnees p)
        {
            _C = p;
        }
        public Forme()
        {
            _C = new Coordonnees();
        }

        public abstract void Affiche();

        public abstract bool CoordonneeEstDans(Coordonnees p);
    }
}
