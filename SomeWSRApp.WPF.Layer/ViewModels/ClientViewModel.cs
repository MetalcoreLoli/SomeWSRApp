using SomeWSRApp.Domain.Layer.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    }
}
