using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using bidcardcoin_WPF_B2.CTRL;
using bidcardcoin_WPF_B2.DAL;
using bidcardcoin_WPF_B2.ORM;

namespace bidcardcoin_WPF_B2.Vue
{
    
    
    
    public partial class listeAdmins : UserControl
    {
        private int selectedAdminId;
        AdminViewModel myDataObjectAdmin;
        ObservableCollection<AdminViewModel> lp;
        int compteur = 0;
        public listeAdmins()
        {
            InitializeComponent();
            
            DALConnection.OpenConnection();
            
            loadAdmins();
        }
        
        void loadAdmins()
        {
            lp = AdminORM.listeAdmin();
            myDataObjectAdmin = new AdminViewModel();
            //LIEN AVEC la VIEW
            listeAdmin.ItemsSource = lp; // bind de la liste avec la source, permettant le binding.
        }
        
        private void listeAdmins_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((listeAdmin.SelectedIndex < lp.Count) && (listeAdmin.SelectedIndex >= 0))
            {
                selectedAdminId = (lp.ElementAt<AdminViewModel>(listeAdmin.SelectedIndex)).idAdminProperty;
            }
        }
        private void SupprButton(object sender, RoutedEventArgs routedEventArgs)
        {
            if (listeAdmin.SelectedItem is AdminViewModel)
            {
                AdminViewModel toRemove = (AdminViewModel)listeAdmin.SelectedItem;
                lp.Remove(toRemove);
                listeAdmin.Items.Refresh();
                AdminORM.supprimerAdmin(selectedAdminId);
                
            }
        }
        
        
        private void ajouterAdmin(object sender, RoutedEventArgs e)
        {
            ajouterAdmin ajouterAdmins = new ajouterAdmin();
            var test = ((StackPanel) this.Parent);
            test.Children.Clear();
            test.Children.Add(ajouterAdmins);
        }
    }
}