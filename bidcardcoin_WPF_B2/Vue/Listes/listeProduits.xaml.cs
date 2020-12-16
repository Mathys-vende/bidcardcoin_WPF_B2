using bidcardcoin_WPF_B2.CTRL;
using bidcardcoin_WPF_B2.ORM;

using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using bidcardcoin_WPF_B2.DAL;
using bidcardcoin_WPF_B2.Vue.ajouter;


namespace bidcardcoin_WPF_B2.Vue
{
    public partial class listeProduits : UserControl
    {
        private int selectedProduitId;
        ProduitViewModel myDataObjectProduit;
        ObservableCollection<ProduitViewModel> lp;
        int compteur = 0;
        public listeProduits()
        {
            InitializeComponent();

            DALConnection.OpenConnection();

            loadProduits();

        }

        private void loadProduits()
        {
            lp = ProduitORM.listeProduit();
            myDataObjectProduit = new ProduitViewModel();
            //LIEN AVEC la VIEW
            listeProduit.ItemsSource = lp; // bind de la liste avec la source, permettant le binding.
        }
        
        private void listeProduit_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((listeProduit.SelectedIndex < lp.Count) && (listeProduit.SelectedIndex >= 0))
            {
                selectedProduitId = (lp.ElementAt<ProduitViewModel>(listeProduit.SelectedIndex)).idProduitProperty;
            }
        }
        private void SupprButton(object sender, RoutedEventArgs routedEventArgs)
        {
            if (listeProduit.SelectedItem is ProduitViewModel)
            {
                ProduitViewModel toRemove = (ProduitViewModel)listeProduit.SelectedItem;
                lp.Remove(toRemove);
                listeProduit.Items.Refresh();
                ProduitORM.supprimerProduit(selectedProduitId);
                
            }
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
        private void Estimation(object sender, RoutedEventArgs e)
        {
            ajoutEstimation estimation = new ajoutEstimation();
            var test = ((StackPanel) this.Parent);
            test.Children.Clear();
            test.Children.Add(estimation);
        }
        
        private void ProduitCategorie(object sender, RoutedEventArgs e)
        {
            ajoutProduitCategorie produitCategorie = new ajoutProduitCategorie();
            var test = ((StackPanel) this.Parent);
            test.Children.Clear();
            test.Children.Add(produitCategorie);

        }
        private void CategorieProduit(object sender, RoutedEventArgs e)
        {
            afficherCategorieProduit produitCategorie = new afficherCategorieProduit();
            var test = ((StackPanel) this.Parent);
            test.Children.Clear();
            test.Children.Add(produitCategorie);

        }

    }
}