using System.Collections.ObjectModel;
using SomeWSRApp.Domain.Layer.Entities;

namespace SomeWSRApp.WPF.Layer.ViewModels
{
    public class SalesPageViewModel : BaseViewModel
    {
        #region Private Members

        private readonly ObservableCollection<SaleEntity> _saleEntities;

        private SaleEntity _selectedEntity;
        #endregion
        
        public SalesPageViewModel()
        {
            _saleEntities = new ObservableCollection<SaleEntity>();
        }

        public ObservableCollection<SaleEntity> SaleEntities => _saleEntities;

        public SaleEntity SelectedEntity
        {
            get => _selectedEntity;
            set => SetProperty(ref _selectedEntity, value);
        }
    }
}