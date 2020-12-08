using System.Windows;
using System.Windows.Controls;

namespace bidcardcoin_WPF_B2.Vue
{
    public partial class ajouterAcheteur : UserControl
    {
        public ajouterAcheteur()
        {
            InitializeComponent();
        }
        
        private void returnListAcheteur(object sender, RoutedEventArgs e)
        {
            listeAcheteurs listeAcheteur = new listeAcheteurs();

            var test = ((StackPanel) this.Parent);
            test.Children.Clear();
            test.Children.Add(listeAcheteur);

        }
    }
}