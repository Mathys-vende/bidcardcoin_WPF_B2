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
    public partial class ajouterAdmin : UserControl
    {
        
        int selectedAdminId;
        AdminViewModel myDataObjectAdmin;
        ObservableCollection<AdminViewModel> Admin;
        int compteur = 0;
        
        private LieuViewModel myDataObjectLieu;

        public ObservableCollection<LieuViewModel> nomLieu;
        public ajouterAdmin()
        {
            InitializeComponent();
            
            DALConnection.OpenConnection();
            
            loadAdmin();
            
            loadLieu();

            appliquerContexte();

        }
        
        
        void loadLieu()
        {
            nomLieu = LieuORM.listeLieu();
            myDataObjectLieu = new LieuViewModel();
            //LIEN AVEC la VIEW
            comboxBoxLieu.ItemsSource = nomLieu; // bind de la liste avec la source, permettant le binding.#1#
            
        }
        
        
        private void AdminButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                myDataObjectAdmin.idAdminProperty = AdminDAL.getMaxIdAdmin() + 1;

                Admin.Add(myDataObjectAdmin);
                AdminORM.insertAdmin(myDataObjectAdmin);
                compteur = Admin.Count();

               
                myDataObjectAdmin = new AdminViewModel();

            
                nomTextBox.DataContext = myDataObjectAdmin;
                prenomTextBox.DataContext = myDataObjectAdmin;
                mailTextBox.DataContext = myDataObjectAdmin;
                numeroTelTextBox.DataContext = myDataObjectAdmin;
                dateVenteTextBox.DataContext = myDataObjectAdmin;
                ageTextBox.DataContext = myDataObjectAdmin;
                comboxBoxLieu.DataContext = myDataObjectAdmin;
                AdminButton.DataContext = myDataObjectAdmin;


            }
            catch(Exception ex)
            {
                MessageBox.Show("A handled exception just occurred: " + ex.Message, "Exception Sample", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        
        void appliquerContexte()
        {
            // Lien avec les textbox
            nomTextBox.DataContext = myDataObjectAdmin;
            prenomTextBox.DataContext = myDataObjectAdmin;
            mailTextBox.DataContext = myDataObjectAdmin;
            numeroTelTextBox.DataContext = myDataObjectAdmin;
            dateVenteTextBox.DataContext = myDataObjectAdmin;
            ageTextBox.DataContext = myDataObjectAdmin;
            comboxBoxLieu.DataContext = myDataObjectAdmin;
            
        }
        
        
        void loadAdmin()
        {
            Admin = AdminORM.listeAdmin();
            myDataObjectAdmin = new AdminViewModel();
           
        }
        
        private void returnListAdmin(object sender, RoutedEventArgs e)
        {
            listeAdmins listeAdmin = new listeAdmins();

            var test = ((StackPanel) this.Parent);
            test.Children.Clear();
            test.Children.Add(listeAdmin);

        }
    }
}