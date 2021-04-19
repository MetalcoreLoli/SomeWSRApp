using System.Windows;
using SomeWSRApp.Domain.Layer.Services;

namespace SomeWSRApp.WPF.Layer.Models.Services
{
    public class DefaultDialogService : IDialogService
    {
        public DialogResult Show(string message, string title)
        {
            return MessageBox.Show(message, title) switch
            {
                MessageBoxResult.OK => DialogResult.Ok,
                _ => DialogResult.Cancel
            };
        }

        public DialogResult ShowError(string message, string title)
        {
            return MessageBox.Show(message, title, MessageBoxButton.OK, MessageBoxImage.Error) switch
            {
                MessageBoxResult.OK => DialogResult.Ok,
                _ => DialogResult.Cancel
            };
        }
    }
}