using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeMe
{
    public class Joueur
    {
        private String name ="";

        private int score =0;

        public Joueur()
        {
        }

        public int Score { get => score; set => score = value; }
        public string Name { get => name; set => name = value; }
    }
}
