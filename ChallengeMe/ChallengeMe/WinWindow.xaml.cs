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
    [System.Runtime.Serialization.DataContract]
    /// <summary>
    /// Logique d'interaction pour WinWindow.xaml
    /// </summary>
    public partial class WinWindow : Window
    {
        [System.Runtime.Serialization.DataMember] private Joueur j;
        private IStorage storage;

        /// <summary>
        /// Constructeur de la fenêtre de fin
        /// </summary>
        /// <param name="j">Joueur</param>
        /// <param name="storage">Stockage</param>
        public WinWindow(Joueur j, IStorage storage)
        {
            InitializeComponent();
            this.j = j;
            this.storage = storage;
        }

        /// <summary>
        /// Quitter le jeu et emmener au Menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quitJeu(object sender, RoutedEventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.ShowDialog();
        }
    }
}
