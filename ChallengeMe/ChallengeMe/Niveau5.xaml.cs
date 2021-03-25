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
    /// Logique d'interaction pour Niveau2.xaml  --> niveau encore pas implémenter
    /// </summary>
    public partial class Niveau5 : Window
    {
        [System.Runtime.Serialization.DataMember] private Joueur j;
        private IStorage storage;

        public Niveau5(Joueur j,IStorage storage)
        {
            InitializeComponent();
            this.j = j;
            this.storage = storage;
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
                if (reponse.Text.ToString() == Convert.ToString(this.j.Score + 5))
                {
                    this.Hide();
                    this.j.Score += 1;
                    storage.Save(j);
                    Niveau6 p = new Niveau6(j,storage);
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
