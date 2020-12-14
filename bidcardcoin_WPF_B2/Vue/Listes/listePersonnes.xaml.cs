using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using bidcardcoin_WPF_B2.CTRL;
using bidcardcoin_WPF_B2.DAL;
using bidcardcoin_WPF_B2.ORM;
using bidcardcoin_WPF_B2.Vue.ajouter;

namespace bidcardcoin_WPF_B2.Vue.Listes
{
    public partial class listePersonnes : UserControl
    {
        
        private int selectedPersonneId;
        PersonneViewModel myDataObjectPersonne;
        ObservableCollection<PersonneViewModel> Personne;
        int compteur = 0;
        
        public listePersonnes()
        {
            InitializeComponent();
            
            DALConnection.OpenConnection();
            
            loadPersonne();
        }
        
        void loadPersonne()
        {
            Personne = PersonneORM.listePersonne();
            myDataObjectPersonne = new PersonneViewModel();
            //LIEN AVEC la VIEW
            listePersonne.ItemsSource = Personne; // bind de la liste avec la source, permettant le binding.
        }
        
        private void listePersonne_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((listePersonne.SelectedIndex < Personne.Count) && (listePersonne.SelectedIndex >= 0))
            {
                selectedPersonneId = (Personne.ElementAt<PersonneViewModel>(listePersonne.SelectedIndex)).idPersonneProperty;
            }
        }
        private void SupprButton(object sender, RoutedEventArgs routedEventArgs)
        {
            if (listePersonne.SelectedItem is PersonneViewModel)
            {
                PersonneViewModel toRemove = (PersonneViewModel)listePersonne.SelectedItem;
                Personne.Remove(toRemove);
                listePersonne.Items.Refresh();
                PersonneORM.supprimerPersonne(selectedPersonneId);
                
            }
        }
        private void ajouterPersonne(object sender, RoutedEventArgs e)
        {
            ajouterPersonne ajouterPersonne = new ajouterPersonne();
            var test = ((StackPanel) this.Parent);
            test.Children.Clear();
            test.Children.Add(ajouterPersonne);
        }
    }
}