using System.Windows;
using bidcardcoin_WPF_B2.Vue.Listes;

namespace bidcardcoin_WPF_B2.Vue
{
    public partial class adminBaseWindow : Window
    {
        public adminBaseWindow()
        {
            InitializeComponent();
        }

        private void listeProduit(object sender, RoutedEventArgs e)
        {

            Child.Children.Clear();
            listeProduits listeProduits = new listeProduits();
            Child.Children.Add(listeProduits);
        }

        private void listeCategorie(object sender, RoutedEventArgs e)
        {
            Child.Children.Clear();
            listeCategories listeCategorie = new listeCategories();
            Child.Children.Add(listeCategorie);


        }
        private void listeEnchère(object sender, RoutedEventArgs e)
        {
            Child.Children.Clear();
            listeEnchères listeEnchère = new listeEnchères();
            Child.Children.Add(listeEnchère);
        }
        
        private void listeLieu(object sender, RoutedEventArgs e)
        {
            Child.Children.Clear();
            listeLieux listeLieu = new listeLieux();
            Child.Children.Add(listeLieu);
        }
        private void listeLot(object sender, RoutedEventArgs e)
        {
            Child.Children.Clear();
            listeLots listeLot = new listeLots();
            Child.Children.Add(listeLot);
        }
        private void listeAdmin(object sender, RoutedEventArgs e)
        {
            Child.Children.Clear();
            listeAdmins listeAdmin = new listeAdmins();
            Child.Children.Add(listeAdmin);
        }
        private void listeVendeur(object sender, RoutedEventArgs e)
        {
            Child.Children.Clear();
            listeVendeurs listeVendeur = new listeVendeurs();
            Child.Children.Add(listeVendeur);
        }
        private void listeAcheteur(object sender, RoutedEventArgs e)
        {
            Child.Children.Clear();
            listeAcheteurs listeAcheteur = new listeAcheteurs();
            Child.Children.Add(listeAcheteur);
        }
        private void listePersonne(object sender, RoutedEventArgs e)
        {
            Child.Children.Clear();
            listePersonnes listePersonnes = new listePersonnes();
            Child.Children.Add(listePersonnes);
        }
        
        
 
    }
}