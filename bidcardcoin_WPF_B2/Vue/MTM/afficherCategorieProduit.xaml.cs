using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using bidcardcoin_WPF_B2.CTRL;
using bidcardcoin_WPF_B2.DAL;
using bidcardcoin_WPF_B2.ORM;

namespace bidcardcoin_WPF_B2.Vue
{
    public partial class afficherCategorieProduit : UserControl
    {
        private int selectedCategorieId;
        private int selectedProduitId;
         private CategorieViewModel myDataObjectCategorie;
        public ObservableCollection<CategorieViewModel> Categorie;
        
        private ProduitCategorieViewModel myDataObjectProduitCategorie;
        public ObservableCollection<ProduitCategorieViewModel> ProduitCategorie;
        
        
        private ProduitViewModel myDataObjectGetProduit;
        public  ProduitViewModel GetProduit;
        
        private ProduitViewModel myDataObjectProduit;
        public ObservableCollection<ProduitViewModel> Produit;
        
        
        public afficherCategorieProduit()
        {
            InitializeComponent();
            
            DALConnection.OpenConnection();
            
            /*loadCategorie();*/

            loadProduitCategorie();

            loadProduit();

            /*appliquerContexte();*/
        }
        
        private void ProduitCategorieButton_Click(object sender, RoutedEventArgs e)
        {

            ProduitCategorie = ProduitCategorieORM.getProduitCategorie(Convert.ToInt32(produitCombobox.SelectedValue.ToString()));
            myDataObjectProduitCategorie = new ProduitCategorieViewModel();
            listeCategorie.DataContext = myDataObjectProduitCategorie;
            listeCategorie.ItemsSource = ProduitCategorie;
            listeCategorie.Items.Refresh();

        }
        private void listeAcheteur_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((listeCategorie.SelectedIndex < ProduitCategorie.Count) && (listeCategorie.SelectedIndex >= 0))
            {
                selectedCategorieId = (ProduitCategorie.ElementAt<ProduitCategorieViewModel>(listeCategorie.SelectedIndex)).IDCategorieProperty;
            }
            
        }
        
        private void SupprButton(object sender, RoutedEventArgs routedEventArgs)
        {
            if (listeCategorie.SelectedItem is ProduitCategorieViewModel)
            {
                ProduitCategorieViewModel toRemove = (ProduitCategorieViewModel)listeCategorie.SelectedItem;
                ProduitCategorie.Remove(toRemove);
                listeCategorie.Items.Refresh();
                ProduitCategorieORM.supprimerProduitCategorie(Convert.ToInt32(produitCombobox.SelectedValue.ToString()),selectedCategorieId );

            }
        }
        void loadCategorie()
        {
            Categorie = CategorieORM.listeCategorie();
            myDataObjectCategorie = new CategorieViewModel();
            //LIEN AVEC la VIEW
            /*listeCategorie.ItemsSource = Categorie; // bind de la liste avec la source, permettant le binding.#3##1#*/
            
        }
        private void CategorieProduit(object sender, RoutedEventArgs e)
        {
            ajoutProduitCategorie ajoutProduitCategorie = new ajoutProduitCategorie();
            var test = ((StackPanel) this.Parent);
            test.Children.Clear();
            test.Children.Add(ajoutProduitCategorie);

        }
        
        void loadProduitCategorie()
        {
            ProduitCategorie = ProduitCategorieORM.listeProduitCategorie();
            myDataObjectProduitCategorie = new ProduitCategorieViewModel();
            //LIEN AVEC la VIEW
            listeCategorie.ItemsSource = ProduitCategorie; // bind de la liste avec la source, permettant le binding.#2#*/
            
        }
        
        void loadProduit()
        {
            Produit = ProduitORM.listeProduit();
            myDataObjectProduit = new ProduitViewModel();
            //LIEN AVEC la VIEW
            produitCombobox.ItemsSource = Produit; // bind de la liste avec la source, permettant le binding.#2#*/
            
        }
    }
}