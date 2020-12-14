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
    public partial class ajouterVendeur : UserControl
    {
        int selectedVendeurId;
        VendeurViewModel myDataObjectVendeur;
        ObservableCollection<VendeurViewModel> Vendeur;
        int compteur = 0;
        
        private PersonneViewModel myDataObjectPersonne;

        public ObservableCollection<PersonneViewModel> Personne;
        public ajouterVendeur()
        {
            InitializeComponent();
            
            DALConnection.OpenConnection();
            
            loadPersonne();
            
            loadVendeur();

            appliquerContexte();

        }
        
        
        void loadPersonne()
        {
            Personne = PersonneORM.listePersonne();
            myDataObjectPersonne = new PersonneViewModel();
            //LIEN AVEC la VIEW
            comboxBoxPersonne.ItemsSource = Personne; // bind de la liste avec la source, permettant le binding.#1#
            
        }
        void loadVendeur()
        {
            Vendeur = VendeurORM.listeVendeur();
            myDataObjectVendeur = new VendeurViewModel();
           
        }
        
        private void VendeurButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                myDataObjectVendeur.idVendeurProperty = VendeurDAL.getMaxIdVendeur() + 1;

                Vendeur.Add(myDataObjectVendeur);
                VendeurORM.insertVendeur(myDataObjectVendeur);
                compteur = Vendeur.Count();

               
                myDataObjectVendeur = new VendeurViewModel();
                
                comboxBoxPersonne.DataContext = myDataObjectVendeur;
            }
            catch(Exception ex)
            {
                MessageBox.Show("A handled exception just occurred: " + ex.Message, "Exception Sample", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        void appliquerContexte()
        {
            
            
            comboxBoxPersonne.DataContext = myDataObjectVendeur;
            
        }
        
        private void returnListVendeur(object sender, RoutedEventArgs e)
        {
            listeVendeurs listeVendeur = new listeVendeurs();

            var test = ((StackPanel) this.Parent);
            test.Children.Clear();
            test.Children.Add(listeVendeur);

        }
    }
}