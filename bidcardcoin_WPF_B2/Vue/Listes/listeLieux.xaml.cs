using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using bidcardcoin_WPF_B2.CTRL;
using bidcardcoin_WPF_B2.DAL;
using bidcardcoin_WPF_B2.ORM;

namespace bidcardcoin_WPF_B2.Vue
{
    public partial class listeLieux : UserControl
    {
        private int selectedLieuId;
        LieuViewModel myDataObject;
        ObservableCollection<LieuViewModel> lp;
        int compteur = 0;
        
        public listeLieux()
        {
            InitializeComponent();
            
            DALConnection.OpenConnection();
            
            loadLieu();
        }
        void loadLieu()
        {
            lp = LieuORM.listeLieu();
            myDataObject = new LieuViewModel();
            //LIEN AVEC la VIEW
            listeLieu.ItemsSource = lp; // bind de la liste avec la source, permettant le binding.
        }
        
        private void listeLieu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((listeLieu.SelectedIndex < lp.Count) && (listeLieu.SelectedIndex >= 0))
            {
                selectedLieuId = (lp.ElementAt<LieuViewModel>(listeLieu.SelectedIndex)).idLieuProperty;
            }
        }
        
        private void SupprButton(object sender, RoutedEventArgs routedEventArgs)
        {
            if (listeLieu.SelectedItem is LieuViewModel)
            {
                LieuViewModel toRemove = (LieuViewModel)listeLieu.SelectedItem;
                lp.Remove(toRemove);
                listeLieu.Items.Refresh();
                LieuORM.supprimerLieu(selectedLieuId);
                
            }
        }
        
        
        private void ajouterlieu(object sender, RoutedEventArgs e)
        {
            ajouterLieu ajouterLieux = new ajouterLieu();
            var test = ((StackPanel) this.Parent);
            test.Children.Clear();
            test.Children.Add(ajouterLieux);
        }
        
        
    }
}