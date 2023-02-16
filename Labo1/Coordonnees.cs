using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo1
{
    internal class Coordonnees
    {
        private int X;

        public int X
        {
            get { return X; }
            set { X = value; }
        }

        private int Y;
        public int Y
        {
            get { return Y; }
            set { Y = value; }
        }

        public Coordonnees(int a, int b)
        {
            X = a;
            Y = b;
        }

        public Coordonnees : this(0, 0)
        {

        }

        public override string ToString()
        {
            return 
        }
    }
}
