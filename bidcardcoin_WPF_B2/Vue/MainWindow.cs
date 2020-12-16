using System.Windows;
using bidcardcoin_WPF_B2.ORM;
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
            string email = txtUsername.Text;
            string mdp = txtPassword.Password;

            //email.Replace("@", ".");

            if (AdminORM.getAuth(email, mdp) >= 1) 
            { 
            //todo: condition d'authentification
                adminBaseWindow admin = new adminBaseWindow();
                this.Close();
                admin.Show(); 
            }
            else
            {
                MessageBox.Show("Email et/ou mot de passe incorrect", email);
            }
    }


    }
}
