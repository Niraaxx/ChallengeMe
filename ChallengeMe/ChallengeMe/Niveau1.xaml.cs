using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
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
    [DataContract]
    /// <summary>
    /// Logique d'interaction pour Partie.xaml
    /// </summary>
    public partial class Niveau1 : Window
    {

        [DataMember] private Joueur j;
        private IStorage storage;
        public Niveau1(Joueur j, IStorage storage)
        {
            InitializeComponent();
            this.j = j;
            this.storage = storage;
        }

        private void pseudoAfficher(object sender, RoutedEventArgs e)
        {
            this.pseudo.Content = j.Name;
        }

        private void scoreAfficher(object sender, RoutedEventArgs e)
        {
            this.scoring.Content = Convert.ToString(j.Score);
        }

        private void changeNiveau(object sender, EventArgs e)
        {
            this.Hide();
            j.Score = j.Score + 1;
            Niveau2 p = new Niveau2(j);
            p.ShowDialog();
        }
    }
}
