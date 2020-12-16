using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using bidcardcoin_WPF_B2.CTRL;
using bidcardcoin_WPF_B2.DAL;
using bidcardcoin_WPF_B2.ORM;
using bidcardcoin_WPF_B2.Vue;

namespace bidcardcoin_WPF_B2.Vue
{
    public partial class ajouterLot : UserControl
    {
        
        int selectedLotId;
        LotViewModel myDataObjectLot;
        ObservableCollection<LotViewModel> lot;
        int compteur = 0;
        
        private EnchereViewModel myDataObjectLieu;
        public ObservableCollection<EnchereViewModel> enchere;
        public ajouterLot()
        {
            InitializeComponent();
            
            DALConnection.OpenConnection();
            
            loadLot();
            
            loadEnchere();

            appliquerContexte();
        }
        
        
        void loadLot()
        {
            lot = LotORM.listeLot();
            myDataObjectLot = new LotViewModel();
            //LIEN AVEC la VIEW
            /*listeLot.ItemsSource = lot; // bind de la liste avec la source, permettant le binding.#1#*/
            
        }
        
        void loadEnchere()
        {
            enchere = EnchereORM.listeEnchere();
            myDataObjectLot = new LotViewModel();
            idEnchereComboBox.ItemsSource = enchere;
        }
        
        private void LotButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                myDataObjectLot.idLotProperty = LotDAL.getMaxIdLot() + 1;

                lot.Add(myDataObjectLot);
                LotORM.insertLot(myDataObjectLot);
                compteur = lot.Count();

                /*listeLot.Items.Refresh();*/
                myDataObjectLot = new LotViewModel();

            
                nomTextBox.DataContext = myDataObjectLot;
                descriptionTextBox.DataContext = myDataObjectLot;
                idEnchereComboBox.DataContext = myDataObjectLot;
                /*idLotTextBox.DataContext = myDataObjectLot;*/

                LotButton.DataContext = myDataObjectLot;
            }
            catch(Exception ex)
            {
                MessageBox.Show("A handled exception just occurred: " + ex.Message, "Exception Sample", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        
        void appliquerContexte()
        {
            // Lien avec les textbox
            nomTextBox.DataContext = myDataObjectLot;
            descriptionTextBox.DataContext = myDataObjectLot;
            idEnchereComboBox.DataContext = myDataObjectLot;
            /*idLotTextBox.DataContext = myDataObjectLot;*/


        }
        
        
        private void returnListLot(object sender, RoutedEventArgs e)
        {
            listeLots listeLot = new listeLots();

            var test = ((StackPanel) this.Parent);
            test.Children.Clear();
            test.Children.Add(listeLot);

        }
    }
}