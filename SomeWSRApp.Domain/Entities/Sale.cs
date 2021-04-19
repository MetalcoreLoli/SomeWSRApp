using System;
using SomeWSRApp.EF.Layer;

namespace SomeWSRApp.Domain.Layer.Entities
{
    public class SaleEntity : Entity
    {
        public StatusEntity Status { get; set; }
        public ClientEntity Client { get; set; }
        
        public DateTime DateOfCreation { get; set; }
        public DateTime DateOfModification { get; set; }
        
        public decimal Sum { get; set; }
    }
}