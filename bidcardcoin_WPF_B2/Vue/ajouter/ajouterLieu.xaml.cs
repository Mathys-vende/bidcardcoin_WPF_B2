using System.Windows;
using System.Windows.Controls;

namespace bidcardcoin_WPF_B2.Vue
{
    public partial class ajouterLieu : UserControl
    {
        public ajouterLieu()
        {
            InitializeComponent();
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