using MaLibrairieForme;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Formats.Asn1.AsnWriter;
using Labo4;
using System.Xml.Linq;

namespace Labo3
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ObservableCollection<Carre> listefomeCarre = new();
        private readonly ObservableCollection<MaLibrairieForme.Rectangle> listefomeRectangle = new();
        private readonly ObservableCollection<Cercle> listefomeCercle = new();

        public MainWindow()
        {
            InitializeComponent();
        }


        private void Ajouter(object sender, RoutedEventArgs e)
        {
            int numerocheckbox = 3, tmp = 0, _x, _y;
            Coordonnees coordonnees = new Coordonnees();

            foreach (CheckBox checkboc in LesCheckbox.Children)
            {
                if (checkboc.IsChecked == false)
                {
                    tmp++;
                }
                else
                {
                    numerocheckbox = tmp;
                }
            }


            if (numerocheckbox == 0)
            {
                if ((ITextBox1.Text.Length <= 0 && ITextBox2.Text.Length <= 0) || (ITextBox4.Text.Length <= 0 || ITextBox5.Text.Length <= 0))
                {
                    MessageBox.Show("Erreur d'encodage !!");
                    return;
                }

                int _cote;
                if (ITextBox1.Text.Length > 0)
                {
                    _cote = int.Parse(ITextBox1.Text);
                }
                else
                {
                    _cote = int.Parse(ITextBox2.Text);
                }

                _x = int.Parse(ITextBox4.Text);
                _y = int.Parse(ITextBox5.Text);

                coordonnees.X = _x;
                coordonnees.Y = _y;

                Carre carre = new Carre(_cote, coordonnees);
                listefomeCarre.Add(carre);
                listBox.ItemsSource = listefomeCarre;
            }

            if (numerocheckbox == 1)
            {
                if ((ITextBox1.Text.Length <= 0 || ITextBox2.Text.Length <= 0) || (ITextBox4.Text.Length <= 0 || ITextBox5.Text.Length <= 0))
                {
                    MessageBox.Show("Erreur d'encodage !!");
                    return;
                }
                int _longueur, _largeur;

                _longueur = int.Parse(ITextBox1.Text);
                _largeur = int.Parse(ITextBox2.Text);
                if (_longueur == _largeur)
                {
                    MessageBox.Show("Erreur la longueur et la largeur sont les même !!");
                    return;
                }
                else
                {
                    _x = int.Parse(ITextBox4.Text);
                    _y = int.Parse(ITextBox5.Text);
                    coordonnees.X = _x;
                    coordonnees.Y = _y;

                    MaLibrairieForme.Rectangle rectangle = new MaLibrairieForme.Rectangle(_longueur, _largeur, coordonnees);
                    listefomeRectangle.Add(rectangle);
                    listBox1.ItemsSource = listefomeRectangle;
                }
            }

            if (numerocheckbox == 2)
            {
                if ((ITextBox3.Text.Length <= 0) || (ITextBox4.Text.Length <= 0 || ITextBox5.Text.Length <= 0))
                {
                    MessageBox.Show("Erreur d'encodage !!");
                    return;
                }
                int _rayon;
                _rayon = int.Parse(ITextBox3.Text);

                _x = int.Parse(ITextBox4.Text);
                _y = int.Parse(ITextBox5.Text);
                coordonnees.X = _x;
                coordonnees.Y = _y;

                Cercle cercle = new Cercle(_rayon, coordonnees);
                listefomeCercle.Add(cercle);
                listBox2.ItemsSource = listefomeCercle;
            }

            if (numerocheckbox == 3)
            {
                MessageBox.Show("AUCUNE FORME SELECTIONNEE !");
            }
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            var clickedBox = sender as CheckBox;
            foreach (var child in (clickedBox.Parent as Panel)?.Children) //(sender as FrameworkElement) converti sender en Pannel
            {
                if (child is CheckBox checkBox && checkBox != clickedBox) //ici on vérifie si l'enfant est une checkbox et si elle est la clickbox
                {
                    checkBox.IsChecked = false; //si oui on met en false
                }
            }
        }

        private void MaListBox_SelectionChanged1(object sender, SelectionChangedEventArgs e)
        {
            var MonItem = listBox.SelectedItem;
            if (MonItem != null)
            {
                var MonCarreSelect = MonItem as Carre;
                if (MonCarreSelect != null)
                {
                    string Affiche = "C : " + MonCarreSelect.Cote + " Coord  : " + MonCarreSelect._C;
                    AfficheResult.Text = Affiche;
                    ITextBox1.Text = MonCarreSelect.Cote.ToString();
                    ITextBox2.Text = "";
                    ITextBox3.Text = "";
                    ITextBox4.Text = MonCarreSelect.C.X.ToString();
                    ITextBox5.Text = MonCarreSelect.C.Y.ToString();

                    CheckBoxCarre.IsChecked = true;
                    CheckBoxRectangle.IsChecked = false;
                    CheckBoxCercle.IsChecked = false;

                    listBox1.SelectedIndex = -1;
                    listBox2.SelectedIndex = -1;
                }
            }
        }

        private void MaListBox_SelectionChanged2(object sender, SelectionChangedEventArgs e)
        {
            var MonItem = listBox1.SelectedItem;
            if (MonItem != null)
            {
                var MonRectangleSelect = MonItem as MaLibrairieForme.Rectangle;
                if (MonRectangleSelect != null)
                {
                    string Affiche = "L : " + MonRectangleSelect.Longueur + " l : " + MonRectangleSelect.Largeur + " Coord : " + MonRectangleSelect._C;
                    AfficheResult.Text = Affiche;
                    ITextBox1.Text = MonRectangleSelect.Longueur.ToString();
                    ITextBox2.Text = MonRectangleSelect.Largeur.ToString(); ;
                    ITextBox3.Text = "";
                    ITextBox4.Text = MonRectangleSelect.C.X.ToString();
                    ITextBox5.Text = MonRectangleSelect.C.Y.ToString();

                    CheckBoxRectangle.IsChecked = true;
                    CheckBoxCarre.IsChecked = false;
                    CheckBoxCercle.IsChecked = false;

                    listBox.SelectedIndex = -1;
                    listBox2.SelectedIndex = -1;
                }
            }
        }

        private void MaListBox_SelectionChanged3(object sender, SelectionChangedEventArgs e)
        {
            var MonItem = listBox2.SelectedItem;
            if (MonItem != null)
            {
                var MonCercleSelect = MonItem as Cercle;
                if (MonCercleSelect != null)
                {
                    string Affiche = "R : " + MonCercleSelect.Rayon + " Coord : " + MonCercleSelect._C;
                    AfficheResult.Text = Affiche;
                    ITextBox1.Text = "";
                    ITextBox2.Text = "";
                    ITextBox3.Text = MonCercleSelect.Rayon.ToString();
                    ITextBox4.Text = MonCercleSelect.C.X.ToString();
                    ITextBox5.Text = MonCercleSelect.C.Y.ToString();

                    CheckBoxCercle.IsChecked = true;
                    CheckBoxRectangle.IsChecked = false;
                    CheckBoxCarre.IsChecked = false;
                    listBox.SelectedIndex = -1;
                    listBox1.SelectedIndex = -1;
                }
            }
        }

        private void NouvelleFenetre(object sender, RoutedEventArgs e)
        {
            // Créer une instance de la deuxième fenêtre
            ModeConfiguration NouvelleFenetre = new ModeConfiguration();
            // Afficher la deuxième fenêtre
            NouvelleFenetre.OptionEvent += OptionEventArg_OptionEvent;
            NouvelleFenetre.Show();
        }

        private void OptionEventArg_OptionEvent(object sender, OptionEventArg e)
        {
            if(e.Couleur != null && e.Police != null)
            {
                MainGrid.Background = (Brush)new BrushConverter().ConvertFromString(e.Couleur);
                BoutonAjouter.FontSize = e.Police;
                Configuration.FontSize = e.Police;
                this.FontSize = e.Police;
            }
            else
            {
                MessageBox.Show("Erreur d'encodage !!");
            }
        }
    }
}
