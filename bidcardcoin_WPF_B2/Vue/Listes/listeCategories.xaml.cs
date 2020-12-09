using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using bidcardcoin_WPF_B2.CTRL;
using bidcardcoin_WPF_B2.ORM;
using Solution;
using System.Linq;

namespace bidcardcoin_WPF_B2.Vue
{
    public partial class listeCategories : UserControl
    {
        private int selectedCategorieId;
        CategorieViewModel myDataObject;
        ObservableCollection<CategorieViewModel> lp;
        int compteur = 0;
  

        public listeCategories()
        {
            InitializeComponent();
            
            DALConnection.OpenConnection();
            
            loadCategories();
            
        }
        
        void loadCategories()
        {
            lp = CategorieORM.listeCategorie();
            myDataObject = new CategorieViewModel();
            //LIEN AVEC la VIEW
            listeCategorie.ItemsSource = lp; // bind de la liste avec la source, permettant le binding.
        }
        private void listeCategories_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((listeCategorie.SelectedIndex < lp.Count) && (listeCategorie.SelectedIndex >= 0))
            {
                selectedCategorieId = (lp.ElementAt<CategorieViewModel>(listeCategorie.SelectedIndex)).idCategorieProperty;
            }
        }
        private void SupprButton(object sender, RoutedEventArgs routedEventArgs)
        {
            if (listeCategorie.SelectedItem is CategorieViewModel)
            {
                CategorieViewModel toRemove = (CategorieViewModel)listeCategorie.SelectedItem;
                lp.Remove(toRemove);
                listeCategorie.Items.Refresh();
                CategorieORM.supprimerCategorie(selectedCategorieId);
                
            }
        }
  
        private void ajouterCategorie(object sender, RoutedEventArgs e)
        {
            ajouterCategorie ajouterCategories = new ajouterCategorie();

            var test = ((StackPanel) this.Parent);
            test.Children.Clear();
            test.Children.Add(ajouterCategories);
            
        }
    }
}