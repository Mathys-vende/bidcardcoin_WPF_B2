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
    public partial class ajouterEnchere : UserControl
    {
        
        int selectedEnchereId;
        EnchereViewModel myDataObjectEnchere;
        ObservableCollection<EnchereViewModel> c;
        int compteur = 0;
        
        private LieuViewModel myDataObjectLieu;
        public ObservableCollection<LieuViewModel> nomLieu;
        
        private AdminViewModel myDataObjectAdmin;
        public ObservableCollection<AdminViewModel> nomAdmin;
        public ajouterEnchere()
        {
            InitializeComponent();
            
            
            
            DALConnection.OpenConnection();
            
            loadEnchere();
            
            loadLieu();

            loadAdmin();

            appliquerContexte();
            
            
        }
        
        void loadLieu()
        {
            nomLieu = LieuORM.listeLieu();
            myDataObjectLieu = new LieuViewModel();
            //LIEN AVEC la VIEW
            comboxBoxLieu.ItemsSource = nomLieu; // bind de la liste avec la source, permettant le binding.*/
            
        }
        
        void loadAdmin()
        {
            nomAdmin = AdminORM.listeAdmin();
            myDataObjectAdmin = new AdminViewModel();
            //LIEN AVEC la VIEW
            idAdmincomboBox.ItemsSource = nomAdmin; // bind de la liste avec la source, permettant le binding.*/
            
        }
        
        void loadEnchere()
        {
            c = EnchereORM.listeEnchere();
            myDataObjectEnchere = new EnchereViewModel();
            listeEncheres.ItemsSource = c;
        }
        
        
        private void EnchereButton_Click(object sender, RoutedEventArgs e)
        {
            
                myDataObjectEnchere.idEnchereProperty = EnchereDAL.getMaxIdEnchere() + 1;

                c.Add(myDataObjectEnchere);
                EnchereORM.insertEnchere(myDataObjectEnchere);
                compteur = c.Count();

                listeEncheres.Items.Refresh();
                myDataObjectEnchere = new EnchereViewModel();

            
                nomTextBox.DataContext = myDataObjectEnchere;
                heureTextBox.DataContext = myDataObjectEnchere;
                dateVenteTextBox.DataContext = myDataObjectEnchere;
                comboxBoxLieu.DataContext = myDataObjectEnchere;
                idAdmincomboBox.DataContext = myDataObjectEnchere;
            
                EnchereButton.DataContext = myDataObjectEnchere;
            }
            
        
        
        void appliquerContexte()
        {
            // Lien avec les textbox
            nomTextBox.DataContext = myDataObjectEnchere;
            heureTextBox.DataContext = myDataObjectEnchere;
            dateVenteTextBox.DataContext = myDataObjectEnchere;
            /*idLieuTextBox.DataContext = myDataObjectEnchere;*/
            comboxBoxLieu.DataContext = myDataObjectEnchere;
            idAdmincomboBox.DataContext = myDataObjectEnchere;

        }
        
        private void returnListEnchere(object sender, RoutedEventArgs e)
        {
            listeEnchères listeEnchère = new listeEnchères();

            var test = ((StackPanel) this.Parent);
            test.Children.Clear();
            test.Children.Add(listeEnchère);
   
        }
    }
}