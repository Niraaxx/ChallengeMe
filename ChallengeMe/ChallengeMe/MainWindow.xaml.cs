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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ChallengeMe;

namespace ChallengeMe
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class Menu : Window
    {
        //Joueur créer pour faire le jeu 
        private Joueur j;

        //Joueur temporaire qui prend les attributs du joueur sauvegardé
        private Joueur j2;

        //Musique dans le jeu
        private Musique mus = new Musique();

        //Création du fichier 
        private IStorage storage = new JsonStorage("player.json");

        public Menu()
        {
            j = storage.Load();
            InitializeComponent();
            mus.playFond();
        }

        private void play(object sender, RoutedEventArgs e)
        {
            //Si c'est le même joueur
            if (j.Nom == j2.Nom)
            {
                //Ouvre la fenêtre en fonction de son score
                switch (j.Score)
                {
                    case 0:
                        if (j.Nom == "")
                        {
                            const string Message = "Il vous faut un nom";
                            MessageBox.Show(Message);
                        }
                        else
                        {
                            Console.WriteLine("Nom : " + this.j.Nom);
                            this.Hide();
                            Niveau1 p = new Niveau1(j, storage);
                            storage.Save(j);
                            p.ShowDialog();
                            this.Show();

                        }
                        break;
                    case 1:
                        this.Hide();
                        Niveau2 p2 = new Niveau2(j, storage);
                        p2.ShowDialog();
                        break;
                    case 2:
                        this.Hide();
                        Niveau3 p3 = new Niveau3(j, storage);
                        p3.ShowDialog();
                        break;
                    case 3:
                        this.Hide();
                        Niveau4 p4 = new Niveau4(j, storage);
                        p4.ShowDialog();
                        break;
                    case 4:
                        this.Hide();
                        Niveau5 p5 = new Niveau5(j, storage);
                        p5.ShowDialog();
                        break;
                    case 5:
                        this.Hide();
                        Niveau6 p6 = new Niveau6(j, storage);
                        p6.ShowDialog();
                        break;
                    case 6:
                        this.Hide();
                        Niveau7 p7 = new Niveau7(j, storage);
                        p7.ShowDialog();
                        break;
                    case 7:
                        this.Hide();
                        Niveau8 p8 = new Niveau8(j, storage);
                        p8.ShowDialog();
                        break;
                    case 8:
                        this.Hide();
                        Niveau9 p9 = new Niveau9(j, storage);
                        p9.ShowDialog();
                        break;
                    case 9:
                        this.Hide();
                        Niveau10 p10 = new Niveau10(j, storage);
                        p10.ShowDialog();
                        break;
                    case 10:
                        this.Hide();
                        Niveau11 p11 = new Niveau11(j, storage);
                        p11.ShowDialog();
                        break;
                    case 11:
                        this.Hide();
                        Niveau12 p12 = new Niveau12(j, storage);
                        p12.ShowDialog();
                        break;
                    case 12:
                        this.Hide();
                        Niveau13 p13 = new Niveau13(j, storage);
                        p13.ShowDialog();
                        break;
                    case 13:
                        this.Hide();
                        Niveau14 p14 = new Niveau14(j, storage);
                        p14.ShowDialog();
                        break;
                    case 14:
                        this.Hide();
                        Niveau15 p15 = new Niveau15(j, storage);
                        p15.ShowDialog();
                        break;
                    case 15:
                        this.Hide();
                        WinWindow p16 = new WinWindow(j, storage);
                        p16.ShowDialog();
                        break;
                }
            }
            else
            {
                //Supprime la sauvegarde du joueur précédent et on en créer une pour le nouveau
                storage.Delete();
                j = j2;
                if (j.Nom == "")
                {
                    const string Message = "Il vous faut un nom";
                    MessageBox.Show(Message);
                }
                else
                {
                    this.Hide();
                    Niveau1 p = new Niveau1(j, storage);
                    storage.Save(j);
                    p.ShowDialog();
                    this.Show();
                }
            }

        }

        /// <summary>
        /// Attribution du nom du joueur temporaire (j2)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void setName(object sender, TextChangedEventArgs e)
        {
            this.j2 = new Joueur();
            this.j2.Nom = txt_name.Text;
        }

        /// <summary>
        /// Fonction pour ouvrir la fenêtre des règles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_regle_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Regle r = new Regle();
            r.ShowDialog();
            if (r.DialogResult == DialogResult.HasValue)
            {
                this.Show();
            }
        }

        private void Quit(object sender, EventArgs e)
        {
            mus.Stop();
        }
    }
}
