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
    /// Logique d'interaction pour Niveau2.xaml  --> niveau encore pas implémenter
    /// </summary>
    public partial class Niveau5 : Window
    {
        private Joueur j;

        public Niveau5(Joueur j)
        {
            InitializeComponent();
            this.j = j;
            this.textQuestion.MouseEnter += new MouseEventHandler(afficherText);
            this.textQuestion.MouseLeave += new MouseEventHandler(effacerText);

        }

        private void effacerText(object sender, MouseEventArgs e)
        {
            this.textQuestion.Foreground = new SolidColorBrush(Colors.Transparent);
        }

        private void afficherText(object sender, MouseEventArgs e)
        {
            this.textQuestion.Foreground = new SolidColorBrush(Colors.Black);
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
                if (reponse.Text.ToString() == Convert.ToString(j.Score + 5))
                {
                    this.Hide();
                    this.j.Score = j.Score + 1;
                    Niveau6 p = new Niveau6(j);
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
