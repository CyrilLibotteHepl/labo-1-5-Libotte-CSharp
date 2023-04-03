using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using MathUtil;


namespace MaLibrairieForme
{
    public class Cercle : Forme
    {
        protected int _Rayon;

        public int Rayon
        {
            get { return _Rayon; }
            set { _Rayon = value; }
        }

        public Cercle(Coordonnees p) : base (p)
        {
            _Rayon = 0;
        }

        public Cercle(int rayon, Coordonnees p) : base (p)
        {
            _Rayon = rayon;
        }

        public override string ToString()
        {
            return "Longueur du rayon du cercle : " + _Rayon + " Coordonnées du cercle : " + _C;
        }

        public override void Affiche()
        {
            Console.WriteLine("\n" + ToString() + "\n");
        }

        public override bool CoordonneeEstDans(Coordonnees p)
        {
            double distance = Math.Sqrt(Math.Pow(p.X - _C.X, 2) + Math.Pow(p.Y - _C.Y, 2));

            return distance <= _Rayon;
        }
    }
}
