using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeMe
{
    /// <summary>
    /// Interface pour la sauvegarde
    /// </summary>
    public interface IStorage
    {
        /// <summary>
        /// Méthode pour sauvegarder le joueur passé en paramètre
        /// </summary>
        /// <param name="j">Joueur à sauvegarder</param>
        void Save(Joueur j);

        /// <summary>
        /// Charge le joueur 
        /// </summary>
        /// <returns>Retourne le joueur</returns>
        Joueur Load();

        /// <summary>
        /// Supprime le contenu du bfichier 
        /// </summary>
        void Delete();
    }
}
