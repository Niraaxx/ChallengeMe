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
    /// Logique d'interaction pour Partie.xaml
    /// </summary>
    public partial class Partie : Window
    {
        private String name;
        private int score = 0;

        public Partie(string name)
        {
            InitializeComponent();
            this.name = name;
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

        private void scoreUpdate(object sender, DataTransferEventArgs e)
        {
            this.scoreAfficher(sender, e);
        }

        private void changeNiveau(object sender, EventArgs e)
        {
            this.Hide();
            this.score = score + 1;
            Niveau1 p = new Niveau1(name,score);
            p.ShowDialog();
        }
    }
}
