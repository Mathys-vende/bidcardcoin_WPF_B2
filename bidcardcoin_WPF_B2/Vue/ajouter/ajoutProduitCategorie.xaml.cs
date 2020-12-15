using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using bidcardcoin_WPF_B2.CTRL;
using bidcardcoin_WPF_B2.DAL;
using bidcardcoin_WPF_B2.ORM;

namespace bidcardcoin_WPF_B2.Vue
{
    public partial class ajoutProduitCategorie : UserControl
    {
        
        private CategorieViewModel myDataObjectCategorie;
        public ObservableCollection<CategorieViewModel> Categorie;
        
        private ProduitCategorieViewModel myDataObjectProduitCategorie;
        public ObservableCollection<ProduitCategorieViewModel> ProduitCategorie;
        
        private ProduitViewModel myDataObjectProduit;
        public ObservableCollection<ProduitViewModel> Produit;
        
        public ajoutProduitCategorie()
        {
            InitializeComponent();
            
            DALConnection.OpenConnection();
            
            loadCategorie();

            loadProduitCategorie();

            loadProduit();

            appliquerContexte();
        }
        
        void loadCategorie()
        {
            Categorie = CategorieORM.listeCategorie();
            myDataObjectCategorie = new CategorieViewModel();
            //LIEN AVEC la VIEW
            categorieCombobox.ItemsSource = Categorie; // bind de la liste avec la source, permettant le binding.#2#*/
            
        }
        
        void loadProduitCategorie()
        {
            ProduitCategorie = ProduitCategorieORM.listeProduitCategorie();
            myDataObjectProduitCategorie = new ProduitCategorieViewModel();
            //LIEN AVEC la VIEW
            /*listePersonne.ItemsSource = Personne; // bind de la liste avec la source, permettant le binding.#2#*/
            
        }
        
        void loadProduit()
        {
            Produit = ProduitORM.listeProduit();
            myDataObjectProduit = new ProduitViewModel();
            //LIEN AVEC la VIEW
            produitCombobox.ItemsSource = Produit; // bind de la liste avec la source, permettant le binding.#2#*/
            
        }
        
        private void ProduitCategorieButton_Click(object sender, RoutedEventArgs e)
        {
            

            ProduitCategorie.Add(myDataObjectProduitCategorie);
            ProduitCategorieORM.insertProduitCategorie(myDataObjectProduitCategorie);
            
            myDataObjectProduitCategorie = new ProduitCategorieViewModel();
            produitCombobox.DataContext = myDataObjectProduitCategorie;
            categorieCombobox.DataContext = myDataObjectProduitCategorie;
            ProduitCategorieButton.DataContext = myDataObjectProduitCategorie;
            
                
                
        }
        
        void appliquerContexte()
        {
            // Lien avec les textbox
            produitCombobox.DataContext = myDataObjectProduitCategorie;
            categorieCombobox.DataContext = myDataObjectProduitCategorie;
        }
        
        private void returnListProduit(object sender, RoutedEventArgs e)
        {
            listeProduits listeProduits = new listeProduits();

            var test = ((StackPanel) this.Parent);
            test.Children.Clear();
            test.Children.Add(listeProduits);
        }
    }
}