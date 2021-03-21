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
    /// Logique d'interaction pour Niveau1.xaml --> Bouton invisible
    /// </summary>
    public partial class Niveau2: Window
    {
        [System.Runtime.Serialization.DataMember] private Joueur j;

        public Niveau2(Joueur j)
        {
            InitializeComponent();
            this.j = j;
        }

        private void pseudoAfficher(object sender, RoutedEventArgs e)
        {
            this.pseudo.Content = this.j.Nom;
        }

        private void scoreAfficher(object sender, RoutedEventArgs e)
        {
            this.scoring.Content = Convert.ToString(j.Score);
        }

        private void ChangerNiveau(object sender, RoutedEventArgs e)
        {
            this.Hide();
            this.j.Score += 1;
            Niveau3 p = new Niveau3(j);
            p.ShowDialog();
        }
    }
}
