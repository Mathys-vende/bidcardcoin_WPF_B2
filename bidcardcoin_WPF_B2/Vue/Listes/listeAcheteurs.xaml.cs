using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media;
using bidcardcoin_WPF_B2.CTRL;
using bidcardcoin_WPF_B2.DAL;
using bidcardcoin_WPF_B2.ORM;
using bidcardcoin_WPF_B2.Vue;
using BorderStyle = System.Web.UI.WebControls.BorderStyle;
using UserControl = System.Windows.Controls.UserControl;

namespace bidcardcoin_WPF_B2.Vue
{
    public partial class listeAcheteurs : UserControl
    {
        public enum OrderStatus { None, New, Processing, Shipped, Received };
        
        private int selectedAcheteurId;
        AcheteurViewModel myDataObjectAcheteur;
        ObservableCollection<AcheteurViewModel> Acheteur;
        public listeAcheteurs()
        {
            InitializeComponent();
            
            DALConnection.OpenConnection();

            

            loadAcheteur();
        }
        
        
        void loadAcheteur()
        {
            Acheteur = AcheteurORM.listeAcheteur();
            myDataObjectAcheteur = new AcheteurViewModel();
            //LIEN AVEC la VIEW
            listeAcheteur.ItemsSource = Acheteur; // bind de la liste avec la source, permettant le binding.
        }
        
        private void listeAcheteur_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((listeAcheteur.SelectedIndex < Acheteur.Count) && (listeAcheteur.SelectedIndex >= 0))
            {
                selectedAcheteurId = (Acheteur.ElementAt<AcheteurViewModel>(listeAcheteur.SelectedIndex)).idAcheteurProperty;
            }
        }
        
        private void SupprButton(object sender, RoutedEventArgs routedEventArgs)
        {
            if (listeAcheteur.SelectedItem is AcheteurViewModel)
            {
                AcheteurViewModel toRemove = (AcheteurViewModel)listeAcheteur.SelectedItem;
                Acheteur.Remove(toRemove);
                listeAcheteur.Items.Refresh();
                AcheteurORM.supprimerAcheteur(selectedAcheteurId);
                
            }
        }

        
        private void ajouterAcheteur(object sender, RoutedEventArgs e)
        {
            ajouterAcheteur ajouterAcheteurs = new ajouterAcheteur();
            var test = ((StackPanel) this.Parent);
            test.Children.Clear();
            test.Children.Add(ajouterAcheteurs);
        }
    }
}