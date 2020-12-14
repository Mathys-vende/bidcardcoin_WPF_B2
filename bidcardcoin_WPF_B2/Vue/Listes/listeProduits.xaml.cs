using bidcardcoin_WPF_B2.CTRL;
using bidcardcoin_WPF_B2.ORM;
using Solution;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;


namespace bidcardcoin_WPF_B2.Vue
{
    public partial class listeProduits : UserControl
    {
        private int selectedProduitId;
        ProduitViewModel myDataObject;
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
            myDataObject = new ProduitViewModel();
            //LIEN AVEC la VIEW
            listeProduit.ItemsSource = lp; // bind de la liste avec la source, permettant le binding.
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