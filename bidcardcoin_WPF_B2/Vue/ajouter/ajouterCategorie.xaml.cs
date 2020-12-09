using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using bidcardcoin_WPF_B2.CTRL;
using bidcardcoin_WPF_B2.ORM;
using bidcardcoin_WPF_B2.DAO;
using Solution;
using System.ComponentModel;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Linq;
using System.Windows.Media;
using System.Collections.ObjectModel;


namespace bidcardcoin_WPF_B2.Vue
{
    public partial class ajouterCategorie : UserControl
    {
        int selectedCategorieId;
        CategorieViewModel myDataObjectCategorie;
        ObservableCollection<CategorieViewModel> c;
        int compteur = 0;
        public ajouterCategorie()
        {
            InitializeComponent();
            
            DALConnection.OpenConnection();
            
            loadCategories();

            appliquerContexte();
        }
        
        private void returnListCategorie(object sender, RoutedEventArgs e)
        {
            listeCategories listeCategorie = new listeCategories();

            var test = ((StackPanel) this.Parent);
            test.Children.Clear();
            test.Children.Add(listeCategorie);
   
        }
        void loadCategories()
        {
            c = CategorieORM.listeCategorie();
            myDataObjectCategorie = new CategorieViewModel();
            listeCategories.ItemsSource = c;
        }
       
        private void nomCategorieButton_Click(object sender, RoutedEventArgs e)
        {
            myDataObjectCategorie.idCategorieProperty = CategorieDAL.getMaxIdCategorie() + 1;

            c.Add(myDataObjectCategorie);
            CategorieORM.insertCategorie(myDataObjectCategorie);
            compteur = c.Count();

            listeCategories.Items.Refresh();
            myDataObjectCategorie = new CategorieViewModel();

            nomCategorie.DataContext = myDataObjectCategorie;
            nomCategorieButton.DataContext = myDataObjectCategorie;
        }
        
        
        
        /*public void nomChanged(object sender, TextChangedEventArgs e)
        {
            myDataObject.nomCategorieProperty = nomTextBox.Text;
        }*/


        void appliquerContexte()
        {
            // Lien avec les textbox
            nomCategorie.DataContext = myDataObjectCategorie;
        }


    }
}