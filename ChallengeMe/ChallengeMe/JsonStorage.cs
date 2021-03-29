using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeMe
{
    public class JsonStorage : IStorage
    {
        //Chemin 
        private string path = "player.json";

        //Fichier
        private String file;

        //Joueur
        private Joueur joueur;

        /// <summary>
        /// Constructeur avec comme paramètre le nom du fichier
        /// </summary>
        /// <param name="file">Fichier</param>
        public JsonStorage(String file)
        {
            this.file = file;
        }

        /// <summary>
        /// Méthode pour supprimer le fichier
        /// </summary>
        public void Delete()
        {
            File.Delete(path);
        }

        /// <summary>
        /// Méthode pour charger le joueur à partir du fichier
        /// </summary>
        /// <returns>Joueur joueur</returns>
        public Joueur Load()
        {
            try
            {
                using (FileStream flux = new FileStream(file, FileMode.Open))
                {
                    System.Runtime.Serialization.Json.DataContractJsonSerializer ser = new System.Runtime.Serialization.Json.DataContractJsonSerializer(typeof(Joueur));
                    joueur = ser.ReadObject(flux) as Joueur;
                }
            }
            catch
            {
                joueur = new Joueur();
            }
            return joueur;
        }

        /// <summary>
        /// Méthode pour sauvegarder le joueur et ses attributs
        /// </summary>
        /// <param name="j">Joueur à sauvegarder</param>
        public void Save(Joueur j)
        {
            try
            {
                using (FileStream flux = new FileStream(file, FileMode.Create))
                {
                    System.Runtime.Serialization.Json.DataContractJsonSerializer ser = new System.Runtime.Serialization.Json.DataContractJsonSerializer(typeof(Joueur));
                    ser.WriteObject(flux, joueur); 
                }
            }
            catch
            {
                new Exception("Erreur de la sauvegarde");
            }
        }
    }
}
