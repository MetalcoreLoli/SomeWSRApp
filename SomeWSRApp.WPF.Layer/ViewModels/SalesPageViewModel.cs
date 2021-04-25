using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using SomeWSRApp.Domain.Layer.Entities;
using SomeWSRApp.EF.Layer;
using SomeWSRApp.EF.Layer.Entities;

namespace SomeWSRApp.WPF.Layer.ViewModels
{
    public class SalesPageViewModel : BaseViewModel
    {
        #region Private Members

        private SaleEntity _selectedEntity;
        #endregion
        
        public SalesPageViewModel()
        {
            SaleEntities = new ObservableCollection<SaleEntity>();
        }

        public string PagesCountFormat { get; set; } = "0 / 0";
        public ObservableCollection<SaleEntity> SaleEntities { get; }
        public ObservableCollection<SaleEntity> PageBuffer { get; }

        public SaleEntity SelectedEntity
        {
            get => _selectedEntity;
            set => SetProperty(ref _selectedEntity, value);
        }
    }
}