using System.Windows;
using System.Windows.Controls;

namespace bidcardcoin_WPF_B2.Vue
{
    public partial class listeAcheteurs : UserControl
    {
        public listeAcheteurs()
        {
            InitializeComponent();
        }
        private void ajouterAcheteur(object sender, RoutedEventArgs e)
        {
            ajouterAcheteur ajouterAcheteurs = new ajouterAcheteur();
            var test = ((StackPanel) this.Parent);
            test.Children.Clear();
            test.Children.Add(ajouterAcheteurs);
        }
    }
}