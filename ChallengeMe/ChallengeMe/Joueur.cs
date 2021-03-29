using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeMe
{
    [Serializable] // Permet de sérialiser 

    public class Joueur
    {
        //Nom du joueur 
        [DataMember] private string nom = "";

        //Score du joueur
        [DataMember] private int score = 0;

        /// <summary>
        /// Getteur & Setteur du score
        /// </summary>
        public int Score { get => score; set => score = value; }

        /// <summary>
        /// Getteur & Setteur du nom
        /// </summary>
        public string Nom { get => nom; set => nom = value; }
    }
}