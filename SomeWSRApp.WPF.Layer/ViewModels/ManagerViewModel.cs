using SomeWSRApp.WPF.Layer.Models.DataModels;

namespace SomeWSRApp.WPF.Layer.ViewModels
{
    public class ManagerViewModel : BaseViewModel
    {
        private ManagerPage _currentPage = ManagerPage.SalesPage;
        public ManagerPage CurrentPage 
        { 
            get => _currentPage;
            set => SetProperty(ref _currentPage, value);
        } 
    }
}