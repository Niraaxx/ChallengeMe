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
    /// Logique d'interaction pour Niveau1.xaml --> Bouton invisible
    /// </summary>
    public partial class Niveau2: Window
    {
        private String name;
        private int score;

        public Niveau2(string name,int score)
        {
            InitializeComponent();
            this.name = name;
            this.score = score;
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

        private void ChangerNiveau(object sender, RoutedEventArgs e)
        {
            this.Hide();
            this.score = score + 1;
            Niveau3 p = new Niveau3(name, score);
            p.ShowDialog();
        }
    }
}
