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
        private System.Media.SoundPlayer fond = new System.Media.SoundPlayer();
        private System.Media.SoundPlayer vict = new System.Media.SoundPlayer();

        public Musique()
        {
            fond.SoundLocation = "fond.wav";
            vict.SoundLocation = "Victoire.wav";
        }

        public void playFond()
        {
            fond.PlayLooping();
        }

        public void playVic()
        {
            vict.Play();
            Thread.Sleep(3000);
            fond.PlayLooping();
        }
    }
}
