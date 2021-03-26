﻿using System;
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
    /// Logique d'interaction pour Niveau10.xaml
    /// </summary>
    public partial class Niveau10 : Window
    {
        [System.Runtime.Serialization.DataMember] private Joueur j;
        private IStorage storage;

        public Niveau10(Joueur j,IStorage storage)
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

        private void changerNiveau(object sender, RoutedEventArgs e)
        {
            this.Close();
            this.j.Score += 1;
            storage.Save(j);
            Niveau11 p = new Niveau11(j,storage);
            p.ShowDialog();
        }

        private void backToMain(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.ShowDialog();
        }
    }
}
