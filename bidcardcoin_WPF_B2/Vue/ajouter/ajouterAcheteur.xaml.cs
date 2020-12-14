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
    public partial class ajouterAcheteur : UserControl
    {
        int selectedAcheteurId;
        AcheteurViewModel myDataObjectAcheteur;
        ObservableCollection<AcheteurViewModel> Acheteur;
        int compteur = 0;
        
        private PersonneViewModel myDataObjectPersonne;

        public ObservableCollection<PersonneViewModel> Personne;
        public ajouterAcheteur()
        {
            InitializeComponent();
            
            DALConnection.OpenConnection();
            
            loadPersonne();
            
            loadAcheteur();

            appliquerContexte();

        }
        
        
        void loadPersonne()
        {
            Personne = PersonneORM.listePersonne();
            myDataObjectPersonne = new PersonneViewModel();
            //LIEN AVEC la VIEW
            comboxBoxPersonne.ItemsSource = Personne; // bind de la liste avec la source, permettant le binding.#1#
            
        }
        void loadAcheteur()
        {
            Acheteur = AcheteurORM.listeAcheteur();
            myDataObjectAcheteur = new AcheteurViewModel();
           
        }
        
        private void AcheteurButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                myDataObjectAcheteur.idAcheteurProperty = AcheteurDAL.getMaxIdAcheteur() + 1;

                Acheteur.Add(myDataObjectAcheteur);
                AcheteurORM.insertAcheteur(myDataObjectAcheteur);
                compteur = Acheteur.Count();

               
                myDataObjectAcheteur = new AcheteurViewModel();
                
               
                soldeTextBox.DataContext = myDataObjectAcheteur;
                isSolvableTextBox.DataContext = myDataObjectAcheteur;
                vérifIdentitéTextBox.DataContext = myDataObjectAcheteur;
                moyenDePaiementTextBox.DataContext = myDataObjectAcheteur;
                comboxBoxPersonne.DataContext = myDataObjectAcheteur;
                AdminButton.DataContext = myDataObjectAcheteur;
            }
            catch(Exception ex)
            {
                MessageBox.Show("A handled exception just occurred: " + ex.Message, "Exception Sample", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        void appliquerContexte()
        {

            soldeTextBox.DataContext = myDataObjectAcheteur;
            isSolvableTextBox.DataContext = myDataObjectAcheteur;
            vérifIdentitéTextBox.DataContext = myDataObjectAcheteur;
            moyenDePaiementTextBox.DataContext = myDataObjectAcheteur;
            comboxBoxPersonne.DataContext = myDataObjectAcheteur;
            
        }
        
        private void returnListAcheteur(object sender, RoutedEventArgs e)
        {
            listeAcheteurs listeAcheteur = new listeAcheteurs();

            var test = ((StackPanel) this.Parent);
            test.Children.Clear();
            test.Children.Add(listeAcheteur);

        }
    }
}