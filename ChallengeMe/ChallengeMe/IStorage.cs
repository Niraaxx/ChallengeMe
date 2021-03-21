using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeMe
{
    public interface IStorage
    {
        void Save(Joueur j);

        Joueur Load();
    }
}
