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

namespace Labo2
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
    }
}
