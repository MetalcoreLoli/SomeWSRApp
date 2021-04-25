using SomeWSRApp.Domain.Layer.Entities;
using SomeWSRApp.EF.Layer.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeWSRApp.WPF.Layer.ViewModels
{
    public class ClientPageViewModel : BaseViewModel
    {
        private ClientEntity _selectedClient;
        public ClientEntity SelectedClient
        {
            get => _selectedClient;
            set => SetProperty(ref _selectedClient, value);
        }
        public ObservableCollection<ClientEntity> Clients { get; set; }

        public ClientPageViewModel()
        {
            var load = Task.Factory.StartNew(() => 
            {
                using var context = new EntityContext();
                context.Client.Load();
                Clients = new ObservableCollection<ClientEntity>(
                    context.Client.Local.Select(c => new ClientEntity 
                    {
                        Id = c.Id,
                        Name = c.DataOfUser.FirstName,
                        LastName = c.DataOfUser.LastName,
                        Source = new SourceEntity(c.Source.Id, c.Source.Name)
                    }));
            });
            load.Wait();
        }
    }
}
