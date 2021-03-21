using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeMe
{
    [Serializable]
    public class Joueur
    {

        [DataMember] private string nom = "";
        [DataMember] private int score = 0;

        public int Score { get => score; set => score = value; }
        public string Nom { get => nom; set => nom = value; }
    }
}