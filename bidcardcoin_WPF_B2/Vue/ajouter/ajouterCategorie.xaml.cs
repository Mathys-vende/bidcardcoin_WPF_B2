using System.Windows;
using System.Windows.Controls;

namespace bidcardcoin_WPF_B2.Vue
{
    public partial class ajouterCategorie : UserControl
    {
        public ajouterCategorie()
        {
            InitializeComponent();
        }
        private void returnListCategorie(object sender, RoutedEventArgs e)
        {
            listeCategories listeCategorie = new listeCategories();

            var test = ((StackPanel) this.Parent);
            test.Children.Clear();
            test.Children.Add(listeCategorie);
   
        }
    }
}