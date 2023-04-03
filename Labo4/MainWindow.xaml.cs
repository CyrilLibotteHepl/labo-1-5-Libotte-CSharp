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

namespace Labo4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ModeConfiguration : Window
    {

        OptionEventArg MonObjet;
        public ModeConfiguration()
        {
            InitializeComponent();
        }
        private void FonctionOk(object sender, RoutedEventArgs e)
        {
            if (CouleurDuFondBox.Text!= null && TaillePolice.Text!=null) 
            {
                MonObjet = new OptionEventArg(CouleurDuFondBox.Text, int.Parse(TaillePolice.Text));
            }
            VariableSave.IsChecked = true;
        }
        private void FonctionCancel(object sender, RoutedEventArgs e)
        {
            if (VariableSave.IsChecked == true)
            {
                VariableSave.IsChecked = false;
                MonObjet = new OptionEventArg();
            }
            else
            {
                this.Close();
            }
        }
        private void FonctionAppliquer(object sender, RoutedEventArgs e)
        {
            if(VariableSave.IsChecked == true)
            {
                OptionEvent?.Invoke(this, MonObjet);
            }
            else
            {
                MessageBox.Show("Veuiller valider la configuration.");
            }
        }
        public event EventHandler<OptionEventArg> OptionEvent;
    }

    public class OptionEventArg : EventArgs
    {
        protected string CouleurFond;
        protected int TaillePol;

        public string Couleur
        {

            get { return CouleurFond; }
            set { CouleurFond = value; }
        }

        public int Police
        {
            get { return TaillePol; }
            set { TaillePol = value; }
        }

        public OptionEventArg(string couleurFond, int taillePol)
        {
            CouleurFond = couleurFond;
            TaillePol = taillePol;
        }
        public OptionEventArg()
        {
            CouleurFond = "";
            TaillePol = 0;
        }
    }
}
