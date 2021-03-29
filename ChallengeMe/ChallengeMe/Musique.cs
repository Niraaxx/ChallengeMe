using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ChallengeMe
{
    
    class Musique
    {
        //Musique de fond
        private System.Media.SoundPlayer fond = new System.Media.SoundPlayer();

        //Musique accomplissement d'une étape
        private System.Media.SoundPlayer vict = new System.Media.SoundPlayer();

        /// <summary>
        /// Constructeur de la classe Musique pour les sons dans le jeu 
        /// </summary>
        public Musique()
        {
            //Assimiliation aux chemins 
            fond.SoundLocation = "fond.wav";
            vict.SoundLocation = "Victoire.wav";
        }

        /// <summary>
        /// Méthode pour jouer la musique de fond
        /// </summary>
        public void playFond()
        {
            fond.PlayLooping();
        }

        /// <summary>
        /// Méthode pour joueur la musique de la victoire d'un niveau
        /// </summary>
        public void playVic()
        {
            vict.Play();
            Thread.Sleep(3000);
            fond.PlayLooping();
        }
    }
}
