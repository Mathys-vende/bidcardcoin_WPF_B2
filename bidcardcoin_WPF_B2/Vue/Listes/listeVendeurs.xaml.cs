using System.Windows;
using System.Windows.Controls;

namespace bidcardcoin_WPF_B2.Vue
{
    public partial class listeVendeurs : UserControl
    {
        public listeVendeurs()
        {
            InitializeComponent();
        }
        private void ajouterVendeur(object sender, RoutedEventArgs e)
        {
            ajouterVendeur ajouterVendeur = new ajouterVendeur();
            var test = ((StackPanel) this.Parent);
            test.Children.Clear();
            test.Children.Add(ajouterVendeur);
        }
    }
}