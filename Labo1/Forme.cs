using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Labo1
{
    public abstract class Forme : IEstDans
    {
        protected Coordonnees pointDaccroche;

        public Coordonnees pointDaccroche
        {
            get { return pointDaccroche; }
            set { pointDaccroche = value; }
        }

        public Forme (Coordonnees cd) 
        { pointDaccroche = cd; }
        public Forme ()
        {
            pointDaccroche = new Coordonnees();
        }
        public abstract void Affiche();
    }
}
