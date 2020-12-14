using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using bidcardcoin_WPF_B2.CTRL;
using bidcardcoin_WPF_B2.DAL;

namespace bidcardcoin_WPF_B2.Vue
{
    public partial class ajouterProduit : UserControl
    {
        private ProduitViewModel myDataObjectProduit;
        public ObservableCollection<ProduitViewModel> Personne;
        int compteur = 0;
        
        public ajouterProduit()
        {
            InitializeComponent();
            
            DALConnection.OpenConnection();
            
            /*
            loadProduit();

            loadLot();

            loadVendeur();

            loadAcheteur();
            
            appliquerContexte();
            */
            
        }


        private void returnListProd(object sender, RoutedEventArgs e)
        {
            listeProduits listeProduits = new listeProduits();

            var test = ((StackPanel) this.Parent);
            test.Children.Clear();
            test.Children.Add(listeProduits);

        }
        
    }
}