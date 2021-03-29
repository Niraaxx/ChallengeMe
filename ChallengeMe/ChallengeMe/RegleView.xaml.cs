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
using System.Windows.Shapes;

namespace ChallengeMe
{
    /// <summary>
    /// Logique d'interaction pour RegleView.xaml
    /// </summary>
    public partial class Regle: Window
    {

        /// <summary>
        /// Constructeur de la fenêtre pour les règles
        /// </summary>
        public Regle()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Méthode qui ferme la fenêtre et retourne au Menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void retour_menu(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
