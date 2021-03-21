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
        private String name;
        private int score;

        public Niveau5(string name, int score)
        {
            InitializeComponent();
            this.name = name;
            this.score = score;
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

        public int Score { get => score; set => score = value; }

        private void pseudoAfficher(object sender, RoutedEventArgs e)
        {
            this.pseudo.Content = this.name;
        }

        private void scoreAfficher(object sender, RoutedEventArgs e)
        {
            this.scoring.Content = Convert.ToString(Score);
        }

        private void changerNiveau(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (reponse.Text.ToString() == Convert.ToString(this.score + 5))
                {
                    this.Hide();
                    this.score = score + 1;
                    Niveau6 p = new Niveau6(name, score);
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
