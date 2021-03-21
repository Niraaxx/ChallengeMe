using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ChallengeMe
{
    [System.Runtime.Serialization.DataContract]
    /// <summary>
    /// Logique d'interaction pour Niveau15.xaml
    /// </summary>
    public partial class Niveau15 : Window
    {
        [System.Runtime.Serialization.DataMember] private Joueur j;
        public Niveau15(Joueur j)
        {
            InitializeComponent();
            this.j = j;
        }
    }
}
