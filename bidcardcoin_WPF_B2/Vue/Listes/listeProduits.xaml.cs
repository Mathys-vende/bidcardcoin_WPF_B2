using System.Windows;
using System.Windows.Controls;


namespace bidcardcoin_WPF_B2.Vue
{
    public partial class listeProduits : UserControl
    {
        public listeProduits()
        {
            InitializeComponent();

        }

        private void ajouterProduit(object sender, RoutedEventArgs e)
        {
            ajouterProduit ajouterProduits = new ajouterProduit ();
            var test = ((StackPanel) this.Parent);
            test.Children.Clear();
            test.Children.Add(ajouterProduits);
        }
        private void OrdreAchat(object sender, RoutedEventArgs e)
        {
            ordreAchat ordre = new ordreAchat();

            
            
            var test = ((StackPanel) this.Parent);
            test.Children.Clear();
            test.Children.Add(ordre);
            
            
        }

    }
}