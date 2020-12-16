using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using bidcardcoin_WPF_B2.CTRL;
using bidcardcoin_WPF_B2.DAL;
using bidcardcoin_WPF_B2.ORM;

namespace bidcardcoin_WPF_B2.Vue
{
    public partial class listeEnchères : UserControl
    {
        private int selectedEnchereId;
        EnchereViewModel myDataObject;
        ObservableCollection<EnchereViewModel> lp;

        private LieuViewModel myDataObjectLieu;
        public ObservableCollection<LieuViewModel> nomLieu;
   

        int compteur = 0;
        public listeEnchères()
        {
            InitializeComponent();
            
            DALConnection.OpenConnection();
            
            loadEnchere();

            loadLieu();

        }
        
   
        
        void loadEnchere()
        {
            lp = EnchereORM.listeEnchere();
            myDataObject = new EnchereViewModel();
            //LIEN AVEC la VIEW
            listeEncheres.ItemsSource = lp; // bind de la liste avec la source, permettant le binding.
        }
        void loadLieu()
        {
            /*nomLieu = LieuORM.listeLieu();
            myDataObjectLieu = new LieuViewModel();
            //LIEN AVEC la VIEW
            ComboBoxColumnLieu.ItemsSource = nomLieu; // bind de la liste avec la source, permettant le binding.*/
        }
        
        private void listeEnchere_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((listeEncheres.SelectedIndex < lp.Count) && (listeEncheres.SelectedIndex >= 0))
            {
                selectedEnchereId = (lp.ElementAt<EnchereViewModel>(listeEncheres.SelectedIndex)).idEnchereProperty;
            }
        }
        
        private void supprEnchere(object sender, RoutedEventArgs routedEventArgs)
        {
            if (listeEncheres.SelectedItem is EnchereViewModel)
            {
                EnchereViewModel toRemove = (EnchereViewModel)listeEncheres.SelectedItem;
                lp.Remove(toRemove);
                listeEncheres.Items.Refresh();
                EnchereORM.supprimerEnchere(selectedEnchereId);
                
            }
        }
        
        
        
        private void ajouterEnchere(object sender, RoutedEventArgs e)
        {
            ajouterEnchere ajouterEncheres = new ajouterEnchere();
            var test = ((StackPanel) this.Parent);
            test.Children.Clear();
            test.Children.Add(ajouterEncheres);
        }
    }
}