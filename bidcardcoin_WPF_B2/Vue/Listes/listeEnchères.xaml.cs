using System.Windows;
using System.Windows.Controls;

namespace bidcardcoin_WPF_B2.Vue
{
    public partial class listeEnchères : UserControl
    {
        public listeEnchères()
        {
            InitializeComponent();
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