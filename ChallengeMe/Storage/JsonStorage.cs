using ChallengeMe;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public class JsonStorage : IStorage
    {

        private string file;
        private Joueur j;

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
                    DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Joueur));
                    j = ser.ReadObject(flux) as Joueur;
                }
            }
            catch
            {
                j = new Joueur();
            }
            return j;
        }

        public void Save(Joueur j)
        {
            try
            {
                using (FileStream flux = new FileStream(file, FileMode.Create))
                {
                    DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Joueur));
                    ser.WriteObject(flux, j);
                }
            }
            catch
            {
                new Exception("Erreur de la sauvegarde");
            }
        }
    }
}
