using System.Windows;
using bidcardcoin_WPF_B2.Vue;

namespace bidcardcoin_WPF_B2
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow
  {


    public MainWindow()
    {
      InitializeComponent();
      
    }
    private void btnSubmit_Click(object sender, RoutedEventArgs e)
    {
      adminBaseWindow admin = new adminBaseWindow();
      this.Close();
      admin.Show();
    }

    
  }
}
