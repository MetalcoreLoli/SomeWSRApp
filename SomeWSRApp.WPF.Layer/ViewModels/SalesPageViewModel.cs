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
            using (var context = new EntityContext())
            {
                context.Sale.LoadAsync();
                var sales = from sale in context.Sale.Local select SaleEntity.CreateFrom(sale);
                SaleEntities = new ObservableCollection<SaleEntity>(sales);
            }
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