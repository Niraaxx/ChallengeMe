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
        private String file;
        private Joueur joueur;

        public JsonStorage(String file)
        {
            this.file = file;
        }
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
