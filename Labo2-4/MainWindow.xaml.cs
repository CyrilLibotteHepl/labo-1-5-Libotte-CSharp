using System;
using System.Collections.Generic;
using System.Linq;
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
using Labo4;

namespace Labo2_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.SizeChanged += Fonction;
        }
        private void Fonction(object sender, SizeChangedEventArgs e)
        {
            if (this.ActualWidth > 400)
            {
                /*Main.Width = (ActualWidth / 3) * 2;
                Hist.Width = Main.Width / 2;
                Hist.Visibility = Visibility.Visible;
                Mbas.Visibility = Visibility.Collapsed;*/
                Hist.Width = new GridLength(1.5, GridUnitType.Star);
                Hist1.Width = new GridLength(1.5, GridUnitType.Star);
                Corbeille.Visibility = Visibility.Visible;
                Mbas.Visibility = Visibility.Collapsed;
                NoHistorique.Width = new GridLength(1.5, GridUnitType.Star);

            }
            else
            {
                /*Main.Width = ActualWidth;
                Hist.Width = 0;
                Hist.Visibility = Visibility.Collapsed;
                Mbas.Visibility = Visibility.Visible;*/
                Hist.Width = new GridLength(0, GridUnitType.Pixel);
                Hist1.Width = new GridLength(0, GridUnitType.Pixel);
                Corbeille.Visibility = Visibility.Collapsed;
                Mbas.Visibility = Visibility.Visible;
                NoHistorique.Width = new GridLength(0, GridUnitType.Pixel);
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
                Main.Background = (Brush)new BrushConverter().ConvertFromString(e.Couleur);
                this.FontSize = e.Police;
                Bt0.FontSize = e.Police;
                Bt1.FontSize = e.Police;
                Bt2.FontSize = e.Police;
                Bt3.FontSize = e.Police;
                Bt4.FontSize = e.Police;
                Bt5.FontSize = e.Police;
                Bt6.FontSize = e.Police;
                Bt7.FontSize = e.Police;
                Bt8.FontSize = e.Police;
                Bt9.FontSize = e.Police;
                Bt10.FontSize = e.Police;
                Bt11.FontSize = e.Police;
                Bt12.FontSize = e.Police;
                Bt13.FontSize = e.Police;
                Bt14.FontSize = e.Police;
                Bt15.FontSize = e.Police;
                Bt16.FontSize = e.Police;
                Bt17.FontSize = e.Police;
                Bt18.FontSize = e.Police;
                Bt19.FontSize = e.Police;
            }
            else
            {
                MessageBox.Show("Erreur d'encodage !!");
            }
        }
    }
}
