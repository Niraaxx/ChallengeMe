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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ChallengeMe
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class Menu : Window
    {
        private String name = "";

        public Menu()
        {
            InitializeComponent();
        }

        public string Name { get => name;}

        private void play(object sender, RoutedEventArgs e)
        {
            if (Name == "")
            {
                const string Message = "Il vous faut un nom";
                MessageBox.Show(Message);
            }
            else{
                Console.WriteLine("Nom : " + this.name);
                this.Hide();
                Partie p = new Partie(name);
                p.ShowDialog();
                if (p.DialogResult == DialogResult.HasValue)
                {
                    this.Show();
                }

            }
        }

        private void setName(object sender, TextChangedEventArgs e)
        {
            this.name = txt_name.Text;
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
