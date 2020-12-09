using System.Windows;
using System.Windows.Controls;

namespace bidcardcoin_WPF_B2.Vue
{
    public partial class listeCategories : UserControl
    {
        public listeCategories()
        {
            InitializeComponent();
        }
        
        private void ajouterCategorie(object sender, RoutedEventArgs e)
        {
            ajouterCategorie ajouterCategories = new ajouterCategorie();

            
            
            var test = ((StackPanel) this.Parent);
            test.Children.Clear();
            test.Children.Add(ajouterCategories);
            
            


            
        }
    }
}