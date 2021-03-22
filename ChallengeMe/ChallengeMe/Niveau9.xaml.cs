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
    /// Logique d'interaction pour Niveau9.xaml
    /// </summary>
    public partial class Niveau9 : Window
    {
        [System.Runtime.Serialization.DataMember] private Joueur j;
        private IStorage storage;

        public Niveau9(Joueur j, IStorage storage)
        {
            InitializeComponent();
            this.j = j;
            this.storage = storage;
        }

        private void pseudoAfficher(object sender, RoutedEventArgs e)
        {
            this.pseudo.Content = this.j.Nom;
        }

        private void scoreAfficher(object sender, RoutedEventArgs e)
        {
            this.scoring.Content = Convert.ToString(j.Score);
        }

        private void changerNiveau(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (reponse.Text.ToString() == Convert.ToString(87))
                {
                    this.Hide();
                    this.j.Score += 1;
                    storage.Save(j);
                    Niveau10 p = new Niveau10(j,storage);
                    p.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Ce n'est pas la bonne réponse !!");
                }
            }
        }
    }
}
