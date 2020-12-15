using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using bidcardcoin_WPF_B2.CTRL;
using bidcardcoin_WPF_B2.DAL;
using bidcardcoin_WPF_B2.ORM;
using bidcardcoin_WPF_B2.Vue.Listes;

namespace bidcardcoin_WPF_B2.Vue.ajouter
{
    public partial class ajouterPersonne : UserControl
    {
        
        private PersonneViewModel myDataObjectPersonne;
        public ObservableCollection<PersonneViewModel> Personne;
        int compteur = 0;
        public ajouterPersonne()
        {
            InitializeComponent();
            
            DALConnection.OpenConnection();
            
            loadPersonne();
            
            appliquerContexte();
        }
        
        void loadPersonne()
        {
            Personne = PersonneORM.listePersonne();
            myDataObjectPersonne = new PersonneViewModel();
            //LIEN AVEC la VIEW
            /*listePersonne.ItemsSource = Personne; // bind de la liste avec la source, permettant le binding.#2#*/
            
        }
        
        private void PersonneButton_Click(object sender, RoutedEventArgs e)
        {
            
            
                myDataObjectPersonne.idPersonneProperty = PersonneDAL.getMaxIdPersonne() + 1;

                Personne.Add(myDataObjectPersonne);
                PersonneORM.insertPersonne(myDataObjectPersonne);
                compteur = Personne.Count();

               
                myDataObjectPersonne = new PersonneViewModel();
                nomTextBox.DataContext = myDataObjectPersonne;
                prenomTextBox.DataContext = myDataObjectPersonne;
                mailTextBox.DataContext = myDataObjectPersonne;
                numeroTelTextBox.DataContext = myDataObjectPersonne;
                motDePasseTextBox.DataContext = myDataObjectPersonne;
                adresseTextBox.DataContext = myDataObjectPersonne;
                codePostalTextBox.DataContext = myDataObjectPersonne;
                ageTextBox.DataContext = myDataObjectPersonne;

                PersonneButton.DataContext = myDataObjectPersonne;
        }
        
        void appliquerContexte()
        {
            // Lien avec les textbox
            nomTextBox.DataContext = myDataObjectPersonne;
            prenomTextBox.DataContext = myDataObjectPersonne;
            mailTextBox.DataContext = myDataObjectPersonne;
            numeroTelTextBox.DataContext = myDataObjectPersonne;
            motDePasseTextBox.DataContext = myDataObjectPersonne;
            adresseTextBox.DataContext = myDataObjectPersonne;
            codePostalTextBox.DataContext = myDataObjectPersonne;
            ageTextBox.DataContext = myDataObjectPersonne;
        }
        
        
        private void returnListPersonne(object sender, RoutedEventArgs e)
        {
            listePersonnes listePersonne = new listePersonnes();

            var test = ((StackPanel) this.Parent);
            test.Children.Clear();
            test.Children.Add(listePersonne);

        }
    }
}