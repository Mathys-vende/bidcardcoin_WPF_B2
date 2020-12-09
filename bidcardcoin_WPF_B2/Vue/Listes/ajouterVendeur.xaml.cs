using System.Windows;
using System.Windows.Controls;

namespace bidcardcoin_WPF_B2.Vue
{
    public partial class ajouterVendeur : UserControl
    {
        public ajouterVendeur()
        {
            InitializeComponent();
        }
        
        private void returnListVendeur(object sender, RoutedEventArgs e)
        {
            listeVendeurs listeVendeur = new listeVendeurs();

            var test = ((StackPanel) this.Parent);
            test.Children.Clear();
            test.Children.Add(listeVendeur);

        }
    }
}