using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using bidcardcoin_WPF_B2.CTRL;
using bidcardcoin_WPF_B2.DAL;
using bidcardcoin_WPF_B2.ORM;

namespace bidcardcoin_WPF_B2.Vue
{
    public partial class listeVendeurs : UserControl
    {
        private int selectedVendeurId;
        VendeurViewModel myDataObject;
        ObservableCollection<VendeurViewModel> Vendeur;

        private PersonneViewModel myDataObjectPersonne;

        public ObservableCollection<PersonneViewModel> Personne;
        public listeVendeurs()
        {
            InitializeComponent();
            
            DALConnection.OpenConnection();
            
            loadVendeur();
            
            /*loadPersonne();*/
        }
        
        void loadVendeur()
        {
            Vendeur = VendeurORM.listeVendeur();
            myDataObject = new VendeurViewModel();
            //LIEN AVEC la VIEW
            listeVendeur.ItemsSource = Vendeur; // bind de la liste avec la source, permettant le binding.
        }
        
        private void listeVendeur_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((listeVendeur.SelectedIndex < Vendeur.Count) && (listeVendeur.SelectedIndex >= 0))
            {
                selectedVendeurId = (Vendeur.ElementAt<VendeurViewModel>(listeVendeur.SelectedIndex)).idVendeurProperty;
            }
        }
        
        private void SupprButton(object sender, RoutedEventArgs routedEventArgs)
        {
            if (listeVendeur.SelectedItem is VendeurViewModel)
            {
                VendeurViewModel toRemove = (VendeurViewModel)listeVendeur.SelectedItem;
                Vendeur.Remove(toRemove);
                listeVendeur.Items.Refresh();
                VendeurORM.supprimerVendeur(selectedVendeurId);
                
            }
        }
        private void ajouterVendeur(object sender, RoutedEventArgs e)
        {
            ajouterVendeur ajouterVendeur = new ajouterVendeur();
            var test = ((StackPanel) this.Parent);
            test.Children.Clear();
            test.Children.Add(ajouterVendeur);
        }
    }
}