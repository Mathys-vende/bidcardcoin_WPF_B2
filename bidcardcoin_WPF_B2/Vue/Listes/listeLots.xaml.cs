using System.Windows;
using System.Windows.Controls;

namespace bidcardcoin_WPF_B2.Vue
{
    public partial class listeLots : UserControl
    {
        public listeLots()
        {
            InitializeComponent();
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