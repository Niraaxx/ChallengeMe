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
    /// Logique d'interaction pour Niveau13.xaml
    /// </summary>
    public partial class Niveau13 : Window
    {
        private Joueur j;

        public Niveau13(Joueur j)
        {
            InitializeComponent();
            this.j = j;
        }

        private void pseudoAfficher(object sender, RoutedEventArgs e)
        {
            this.pseudo.Content = this.j.Name;
        }

        private void scoreAfficher(object sender, RoutedEventArgs e)
        {
            this.scoring.Content = Convert.ToString(j.Score);
        }

        private void changerNiveau(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (reponse.Text.ToString() == Convert.ToString(2))
                {
                    this.Hide();
                    this.j.Score = j.Score + 1;
                    Niveau14 p = new Niveau14(j);
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
