namespace MathUtil
{
    public class MathUtil
    {
        public int _Longueur;
        public int _Largeur;
        public int _Cote;
        public int _Rayon;
        public double min;
        public double max;
        public double val;
        public double Surface;
        
        public double RRectangle (int longueur, int largeur)
        {
            return Surface = (double)longueur * (double)largeur;
        }

        public double RCarre (int cote)
        {
            return Surface = (double)cote * (double)cote;
        }

        public double RCercle (int rayon)
        {
            return Surface = (double)3.14 * (double)Math.Pow(rayon, 2); //ici pow est exécuter avant la multiplication
        }

        public bool Intervale(double min, double max, double val)
        {
            if (val < max && val > min)
                return true;
            else
                return false;
        }
    }
}