using System.Windows;
using System.Windows.Controls;

namespace bidcardcoin_WPF_B2.Vue
{
    public partial class ajouterAdmin : UserControl
    {
        public ajouterAdmin()
        {
            InitializeComponent();
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