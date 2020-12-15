using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using bidcardcoin_WPF_B2.CTRL;
using bidcardcoin_WPF_B2.DAL;
using bidcardcoin_WPF_B2.ORM;

namespace bidcardcoin_WPF_B2.Vue.ajouter
{
    public partial class ajoutEstimation : UserControl
    
    {
        private ProduitViewModel myDataObjectProduit;
        public ObservableCollection<ProduitViewModel> Produit;
        
        private AdminViewModel myDataObjectAdmin;
        public ObservableCollection<AdminViewModel> Admin;
        
        private EstimationViewModel myDataObjectEstimation;
        public ObservableCollection<EstimationViewModel> Estimation;
        
        public ajoutEstimation()
        {
            InitializeComponent();
            
            DALConnection.OpenConnection();

            loadEstimation();

            loadProduit();

            loadAdmin();
            
            appliquerContexte();
            
        }
        
        void loadProduit()
        {
            Produit = ProduitORM.listeProduit();
            myDataObjectProduit = new ProduitViewModel();
            //LIEN AVEC la VIEW
            ProduitCombobox.ItemsSource = Produit; // bind de la liste avec la source, permettant le binding.#2#*/
            
        }
        void loadAdmin()
        {
            Admin = AdminORM.listeAdmin();
            myDataObjectAdmin = new AdminViewModel();
            //LIEN AVEC la VIEW
            AdminCombobox.ItemsSource = Admin; // bind de la liste avec la source, permettant le binding.#2#*/
            
        }
        void loadEstimation()
        {
            Estimation = EstimationORM.listeEstimation();
            myDataObjectEstimation = new EstimationViewModel();
            //LIEN AVEC la VIEW
            //AdminCombobox.ItemsSource = Admin; // bind de la liste avec la source, permettant le binding.#2#*/
            
        }
        
        private void EstimationButton_Click(object sender, RoutedEventArgs e)
        {
            

            Estimation.Add(myDataObjectEstimation);
            EstimationORM.insertEstimation(myDataObjectEstimation);
            
            myDataObjectEstimation = new EstimationViewModel();
            
            ProduitCombobox.DataContext = myDataObjectEstimation;
            AdminCombobox.DataContext = myDataObjectEstimation;
            EstimationTextBox.DataContext = myDataObjectEstimation;
            dateEstimationcalendar.DataContext = myDataObjectEstimation;
 

        }
        
        void appliquerContexte()
        {
            // Lien avec les textbox
           
            ProduitCombobox.DataContext = myDataObjectEstimation;
            AdminCombobox.DataContext = myDataObjectEstimation;
            EstimationTextBox.DataContext = myDataObjectEstimation;
            dateEstimationcalendar.DataContext = myDataObjectEstimation;
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