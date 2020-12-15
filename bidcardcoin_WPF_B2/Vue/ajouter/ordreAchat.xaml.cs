using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using bidcardcoin_WPF_B2.CTRL;
using bidcardcoin_WPF_B2.DAL;
using bidcardcoin_WPF_B2.ORM;

namespace bidcardcoin_WPF_B2.Vue
{
    public partial class ordreAchat : UserControl
    {
        
       
        private OrdreachatViewModel myDataObjectOrdreachat;
        public ObservableCollection<OrdreachatViewModel> Ordreachat;
        
        private EnchereViewModel myDataObjectEnchere;
        public ObservableCollection<EnchereViewModel> Enchere;
        
        private ProduitViewModel myDataObjectProduit;
        public ObservableCollection<ProduitViewModel> Produit;
        
        private AcheteurViewModel myDataObjectAcheteur;
        public ObservableCollection<AcheteurViewModel> Acheteur;
        
        public ordreAchat()
        {
            InitializeComponent();
            
            DALConnection.OpenConnection();

            loadAcheteur();

            loadOrdreAchat();

            loadProduit();

            loadEnchere();

            appliquerContexte();
        }
        
        void loadAcheteur()
        {
            Acheteur = AcheteurORM.listeAcheteur();
            myDataObjectAcheteur = new AcheteurViewModel();
            //LIEN AVEC la VIEW
            AcheteurCombobox.ItemsSource = Acheteur; // bind de la liste avec la source, permettant le binding.#2#*/
        }
        void loadProduit()
        {
            Produit = ProduitORM.listeProduit();
            myDataObjectProduit = new ProduitViewModel();
            //LIEN AVEC la VIEW
            ProduitCombobox.ItemsSource = Produit; // bind de la liste avec la source, permettant le binding.#2#*/
        }
        void loadOrdreAchat()
        {
            Ordreachat = OrdreachatORM.listeOrdreachat();
            myDataObjectOrdreachat = new OrdreachatViewModel();
            //LIEN AVEC la VIEW
           
        }
        void loadEnchere()
        {
            Enchere = EnchereORM.listeEnchere();
            myDataObjectEnchere = new EnchereViewModel();
            //LIEN AVEC la VIEW
            EnchereCombobox.ItemsSource = Enchere; // bind de la liste avec la source, permettant le binding.#2#*/
        }
        
        private void OrdreAchatButton_Click(object sender, RoutedEventArgs e)
        {
            

            Ordreachat.Add(myDataObjectOrdreachat);
            OrdreachatORM.insertOrdreachat(myDataObjectOrdreachat);
            
            myDataObjectOrdreachat = new OrdreachatViewModel();
            AcheteurCombobox.DataContext = myDataObjectOrdreachat;
            ProduitCombobox.DataContext = myDataObjectOrdreachat;
            EnchereCombobox.DataContext = myDataObjectOrdreachat;
            montantMaxTextBox.DataContext = myDataObjectOrdreachat;
            adresseDepotTextBox.DataContext = myDataObjectOrdreachat;
            OrdreAchatCategorieButton.DataContext = myDataObjectOrdreachat;
        }
        void appliquerContexte()
        {
            // Lien avec les textbox
            AcheteurCombobox.DataContext = myDataObjectOrdreachat;
            ProduitCombobox.DataContext = myDataObjectOrdreachat;
            EnchereCombobox.DataContext = myDataObjectOrdreachat;
            montantMaxTextBox.DataContext = myDataObjectOrdreachat;
            adresseDepotTextBox.DataContext = myDataObjectOrdreachat;
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