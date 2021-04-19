using SomeWSRApp.Domain.Layer.Services;

namespace SomeWSRApp.WPF.Layer.Models.Services
{
    public interface IDialogService
    {
        DialogResult Show(string message, string title);

        DialogResult ShowError(string message, string title);
    }
}