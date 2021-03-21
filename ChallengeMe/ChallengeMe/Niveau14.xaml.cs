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
    /// Logique d'interaction pour Niveau14.xaml
    /// </summary>
    public partial class Niveau14 : Window
    {
        private Joueur j;

        public Niveau14(Joueur j)
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
                if (reponse.Text.ToString() == Convert.ToString(6))
                {
                    this.Hide();
<<<<<<< HEAD
                    this.j.Score = j.Score + 1;
                    Niveau1 p = new Niveau1(j);
=======
                    this.score = score + 1;
<<<<<<< HEAD
                    Niveau1 p = new Niveau1(name, score);
=======
                    Niveau15 p = new Niveau15(name, score);
>>>>>>> af6e4ca33b6f63ab1832e3a7d94e043ff6ea8a2f
>>>>>>> parent of ea937af (Marche bien)
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
