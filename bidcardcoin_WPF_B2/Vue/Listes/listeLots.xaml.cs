using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using bidcardcoin_WPF_B2.CTRL;
using bidcardcoin_WPF_B2.DAL;
using bidcardcoin_WPF_B2.ORM;

namespace bidcardcoin_WPF_B2.Vue
{
    public partial class listeLots : UserControl
    {
        private int selectedLotId;
        LotViewModel myDataObject;
        ObservableCollection<LotViewModel> lp;
        int compteur = 0;
        public listeLots()
        {
            InitializeComponent();
            
            DALConnection.OpenConnection();
            
            loadLot();
        }
        
        void loadLot()
        {
            lp = LotORM.listeLot();
            myDataObject = new LotViewModel();
            //LIEN AVEC la VIEW
            listeLot.ItemsSource = lp; // bind de la liste avec la source, permettant le binding.
        }
        
        private void listeLot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((listeLot.SelectedIndex < lp.Count) && (listeLot.SelectedIndex >= 0))
            {
                selectedLotId = (lp.ElementAt<LotViewModel>(listeLot.SelectedIndex)).idLotProperty;
            }
        }
        
        private void SupprButton(object sender, RoutedEventArgs routedEventArgs)
        {
            if (listeLot.SelectedItem is LotViewModel)
            {
                LotViewModel toRemove = (LotViewModel)listeLot.SelectedItem;
                lp.Remove(toRemove);
                listeLot.Items.Refresh();
                LotORM.supprimerLot(selectedLotId);
                
            }
        }
        
        private void ajouterLot(object sender, RoutedEventArgs e)
        {
            ajouterLot ajouterlots = new ajouterLot();
            var test = ((StackPanel) this.Parent);
            test.Children.Clear();
            test.Children.Add(ajouterlots);
        }
    }
}