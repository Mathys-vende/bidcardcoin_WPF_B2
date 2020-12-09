using System.Windows;
using System.Windows.Controls;
using bidcardcoin_WPF_B2.Vue;

namespace bidcardcoin_WPF_B2.Vue
{
    public partial class ajouterLot : UserControl
    {
        public ajouterLot()
        {
            InitializeComponent();
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