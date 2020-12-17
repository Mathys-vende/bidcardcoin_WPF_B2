using System.Collections.ObjectModel;
using System.Windows;
using System.Linq;
using System.Windows.Controls;
using bidcardcoin_WPF_B2.CTRL;
using bidcardcoin_WPF_B2.DAL;
using bidcardcoin_WPF_B2.ORM;

namespace bidcardcoin_WPF_B2.Vue
{
    public partial class ajouterProduit : UserControl
    {
        private ProduitViewModel myDataObjectProduit;
        public ObservableCollection<ProduitViewModel> Produit;

        private LotViewModel myDataObjectlot;
        public ObservableCollection<LotViewModel> lot;

        private AcheteurViewModel myDataObjectAcheteur;
        public ObservableCollection<AcheteurViewModel> Acheteur;

        private VendeurViewModel myDataObjectVendeur;
        public ObservableCollection<VendeurViewModel> Vendeur;
        int compteur = 0;

        public ajouterProduit()
        {
            InitializeComponent();

            DALConnection.OpenConnection();


            loadProduit();

            loadlot();

            loadVendeur();

            loadAcheteur();



            appliquerContexte();


        }

        void loadProduit()
        {
            Produit = ProduitORM.listeProduit();
            myDataObjectProduit = new ProduitViewModel();
            //LIEN AVEC la VIEW
            /*listeProduit.ItemsSource = Produit; // bind de la liste avec la source, permettant le binding.#3##1#*/

        }
        void loadlot()
        {
            lot = LotORM.listeLot();
            myDataObjectlot = new LotViewModel();
            //LIEN AVEC la VIEW
            comboxBoxLot.ItemsSource = lot; // bind de la liste avec la source, permettant le binding.#3##1#*/

        }
        void loadAcheteur()
        {
            Acheteur = AcheteurORM.listeAcheteur();
            myDataObjectAcheteur = new AcheteurViewModel();
            //LIEN AVEC la VIEW
            IDAcheteurTextBox.ItemsSource = Acheteur; // bind de la liste avec la source, permettant le binding.#3##1#*/
        }
        void loadVendeur()
        {
            Vendeur = VendeurORM.listeVendeur();
            myDataObjectVendeur = new VendeurViewModel();
            //LIEN AVEC la VIEW
            IDVendeurTextBox.ItemsSource = Vendeur; // bind de la liste avec la source, permettant le binding.#3##1#*/

        }
        private void ProduitButton_Click(object sender, RoutedEventArgs e)
        {


            myDataObjectProduit.idProduitProperty = ProduitDAL.getMaxIdProduit() + 1;

            IDPhotoTextBox.DataContext = 1;
            Produit.Add(myDataObjectProduit);
            ProduitORM.insertProduit(myDataObjectProduit);
            compteur = Produit.Count();


            myDataObjectProduit = new ProduitViewModel();

            EstimationTextBox.DataContext = myDataObjectProduit;
            PrixVenteTextBox.DataContext = myDataObjectProduit;
            NomTextBox.DataContext = myDataObjectProduit;
            DescriptionTextBox.DataContext = myDataObjectProduit;
            ArtisteTextBox.DataContext = myDataObjectProduit;
            StyleTextBox.DataContext = myDataObjectProduit;
            comboxBoxLot.DataContext = myDataObjectProduit;
            IDPhotoTextBox.DataContext = myDataObjectProduit;
            IDAcheteurTextBox.DataContext = myDataObjectProduit;
            IDVendeurTextBox.DataContext = myDataObjectProduit;
            ProduitButton.DataContext = myDataObjectProduit;

        }
        void appliquerContexte()
        {
            // Lien avec les textbox
            EstimationTextBox.DataContext = myDataObjectProduit;
            PrixVenteTextBox.DataContext = myDataObjectProduit;
            NomTextBox.DataContext = myDataObjectProduit;
            DescriptionTextBox.DataContext = myDataObjectProduit;
            ArtisteTextBox.DataContext = myDataObjectProduit;
            StyleTextBox.DataContext = myDataObjectProduit;
            comboxBoxLot.DataContext = myDataObjectProduit;
            IDPhotoTextBox.DataContext = myDataObjectProduit;
            IDAcheteurTextBox.DataContext = myDataObjectProduit;
            IDVendeurTextBox.DataContext = myDataObjectProduit;
        }

        private void returnListProduit(object sender, RoutedEventArgs e)
        {
            listeProduits listeProduits = new listeProduits();

            var test = ((StackPanel)this.Parent);
            test.Children.Clear();
            test.Children.Add(listeProduits);

        }

    }
}