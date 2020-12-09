using System.Windows;
using System.Windows.Controls;

namespace bidcardcoin_WPF_B2.Vue
{
    public partial class ajouterEnchere : UserControl
    {
        public ajouterEnchere()
        {
            InitializeComponent();
        }
        
        private void returnListEnchere(object sender, RoutedEventArgs e)
        {
            listeEnchères listeEnchère = new listeEnchères();

            var test = ((StackPanel) this.Parent);
            test.Children.Clear();
            test.Children.Add(listeEnchère);
   
        }
    }
}