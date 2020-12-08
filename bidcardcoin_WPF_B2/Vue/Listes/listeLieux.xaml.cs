using System.Windows;
using System.Windows.Controls;

namespace bidcardcoin_WPF_B2.Vue
{
    public partial class listeLieux : UserControl
    {
        public listeLieux()
        {
            InitializeComponent();
        }
        private void ajouterlieu(object sender, RoutedEventArgs e)
        {
            ajouterLieu ajouterLieux = new ajouterLieu();
            var test = ((StackPanel) this.Parent);
            test.Children.Clear();
            test.Children.Add(ajouterLieux);
        }
        
        
    }
}