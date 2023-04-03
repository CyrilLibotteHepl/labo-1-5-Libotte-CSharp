// See https://aka.ms/new-console-template for more information


using MaLibrairieForme;
using MathUtil;
using System.Diagnostics;

#region CreationObj

Coordonnees coordonnees1 = new Coordonnees();
coordonnees1.X = 1;
coordonnees1.Y = 1;

Coordonnees coordonnees2 = new Coordonnees();
coordonnees2.X = 2;
coordonnees2.Y = 5;

Console.WriteLine("\n1 : ");
coordonnees1.Affiche();
Console.WriteLine("2 : ");
coordonnees2.Affiche();

Carre carre1 = new Carre(3, coordonnees1);
Carre carre2 = new Carre(2, coordonnees2);

Console.WriteLine("\n1 : ");
carre1.Affiche();
Console.WriteLine("2 : ");
carre2.Affiche();

Cercle cercle1 = new Cercle(7, coordonnees1);
Cercle cercle2 = new Cercle(2, coordonnees2);

Console.WriteLine("\n1 : ");
cercle1.Affiche();
Console.WriteLine("2 : ");
cercle2.Affiche();

Rectangle rectangle1 = new Rectangle(3, 2, coordonnees1);
Rectangle rectangle2 = new Rectangle(5, 4, coordonnees2);

Console.WriteLine("\n1 : ");
rectangle1.Affiche();
Console.WriteLine("2 : ");
rectangle2.Affiche();

#endregion 

Console.WriteLine("\nListe des forme : \n");
#region ListeForme
List<Forme> formeListe = new List<Forme>();

formeListe.Add(carre1);
formeListe.Add(carre2);
formeListe.Add(rectangle1);
formeListe.Add(rectangle2);
formeListe.Add(cercle1);
formeListe.Add(cercle2);

foreach (Forme f in formeListe)
{
    f.Affiche();
}
#endregion 

#region ListeAvecISommet

Console.WriteLine("\nAvec ISommets : ");
foreach (Forme forme in formeListe)
{

    if ((forme is ISommets))
    {
        Console.WriteLine("Implémente ISOMMETS!");
        forme.Affiche();
    }
}

Console.WriteLine("\nSans ISommets : ");
foreach (Forme forme in formeListe)
{
    if (!(forme is ISommets))
    {
        Console.WriteLine("n'implemente pas ISOMMETS!");
        forme.Affiche();
    }
}
#endregion

#region CarreTrie
Console.WriteLine("\nCreation de la liste des carres : \n");
List<Carre> carreListe = new List<Carre>();

carreListe.Add(new Carre(3, coordonnees1));
carreListe.Add(new Carre(2, coordonnees2));
carreListe.Add(new Carre(1, coordonnees1));
carreListe.Add(new Carre(4, coordonnees2));
carreListe.Add(new Carre(5, coordonnees1));

Console.WriteLine("\nTri de la liste par ordre croissant.\n");
carreListe.Sort();

foreach(Carre carre in carreListe)
{
    carre.Affiche();
}

Console.WriteLine("\nTri de la liste par ordre décroissant.\n");
carreListe.Reverse();

foreach (Carre carre in carreListe)
{
    carre.Affiche();
}
#endregion


/*#region FormeAbscisseComparer
Console.WriteLine("\nTri de la liste par abscisse.\n");
FormeAbscisseComparer abs = new FormeAbscisseComparer();
carreListe.Sort(abs);

foreach (Carre carre in carreListe)
{
    carre.Affiche();
}

#endregion*/
