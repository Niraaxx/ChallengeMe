using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Storage;

namespace ChallengeMe
{
    [DataContract]
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class Menu : Window
    {
        [DataMember] private Joueur j;
        private IStorage storage;

        public Menu()
        {
            j = new Joueur();
            InitializeComponent();
            storage = new JsonStorage("save.json");
            j = storage.Load();
            
        }


        private void play(object sender, RoutedEventArgs e)
        {
            if (j.Name == "")
            {
                const string Message = "Il vous faut un nom";
                MessageBox.Show(Message);
            }
            else{
                Console.WriteLine("Nom : " + j.Name);
                this.Hide();
                Niveau1 p = new Niveau1(j);
                p.ShowDialog();
                if (p.DialogResult == DialogResult.HasValue)
                {
                    this.Show();
                }

            }
        }

        private void setName(object sender, TextChangedEventArgs e)
        {
            j.Name = txt_name.Text;
        }

        private void btn_regle_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Regle r = new Regle();
            r.ShowDialog();
            if (r.DialogResult == DialogResult.HasValue)
            {
                this.Show();
            }
        }
    }
}
