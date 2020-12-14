using System.Windows.Threading;

namespace bidcardcoin_WPF_B2
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App
  {
    
    void App_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
    {
      // Process unhandled exception

      // Prevent default unhandled exception processing
      e.Handled = true;
    }
  }
}
