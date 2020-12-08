using System.Windows;
using System.Windows.Controls;

namespace bidcardcoin_WPF_B2.Vue
{
    public partial class listeAdmins : UserControl
    {
        public listeAdmins()
        {
            InitializeComponent();
        }
        private void ajouterAdmin(object sender, RoutedEventArgs e)
        {
            ajouterAdmin ajouterAdmins = new ajouterAdmin();
            var test = ((StackPanel) this.Parent);
            test.Children.Clear();
            test.Children.Add(ajouterAdmins);
        }
    }
}