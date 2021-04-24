using System.Windows;
using System.Windows.Controls;

namespace SomeWSRApp.WPF.Layer.Views
{
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void CloseButtonClick(object sender, RoutedEventArgs e)
        {
            loginVM.CloseCommand.Execute(this);
        }

        private void LogInButtonClick(object sender, RoutedEventArgs e)
        {
            loginVM.LoginCommand.Execute(null);
        }
    }
}