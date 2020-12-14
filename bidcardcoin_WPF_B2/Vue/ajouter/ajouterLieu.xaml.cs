using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using bidcardcoin_WPF_B2.CTRL;
using bidcardcoin_WPF_B2.DAL;
using bidcardcoin_WPF_B2.ORM;

namespace bidcardcoin_WPF_B2.Vue
{
    public partial class ajouterLieu : UserControl
    {
        int selectedLieuId;
        LieuViewModel myDataObjectLieu;
        ObservableCollection<LieuViewModel> c;
        int compteur = 0;
        public ajouterLieu()
        {
            InitializeComponent();
            
            
            DALConnection.OpenConnection();
            
            loadLieu();

            appliquerContexte();
        }
        
        void loadLieu()
        {
            c = LieuORM.listeLieu();
            myDataObjectLieu = new LieuViewModel();
            listeLieu.ItemsSource = c;
        }
        
        private void LieuButton_Click(object sender, RoutedEventArgs e)
        {
            myDataObjectLieu.idLieuProperty = LieuDAL.getMaxIdLieu() + 1;

            c.Add(myDataObjectLieu);
            LieuORM.insertLieu(myDataObjectLieu);
            compteur = c.Count();

            listeLieu.Items.Refresh();
            myDataObjectLieu = new LieuViewModel();

            villeTextBox.DataContext = myDataObjectLieu;
            adresseTextBox.DataContext = myDataObjectLieu;
            codePostalTextBox.DataContext = myDataObjectLieu;
            departementTextBox.DataContext = myDataObjectLieu;
            LieuButton.DataContext = myDataObjectLieu;
        }
        
        void appliquerContexte()
        {
            // Lien avec les textbox
            villeTextBox.DataContext = myDataObjectLieu;
            adresseTextBox.DataContext = myDataObjectLieu;
            codePostalTextBox.DataContext = myDataObjectLieu;
            departementTextBox.DataContext = myDataObjectLieu;
        }
        
        private void returnListLieu(object sender, RoutedEventArgs e)
        {
            listeLieux listelieu = new listeLieux();

            var test = ((StackPanel) this.Parent);
            test.Children.Clear();
            test.Children.Add(listelieu);
   
        }
    }
}