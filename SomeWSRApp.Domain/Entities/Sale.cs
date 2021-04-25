using System;
using SomeWSRApp.Domain.Layer.Builders;
using SomeWSRApp.EF.Layer;
using SomeWSRApp.EF.Layer.Entities;

namespace SomeWSRApp.Domain.Layer.Entities
{
    public class SaleEntity : Entity
    {
        public StatusEntity Status { get; set; }
        public ClientEntity Client { get; set; }
        
        public DateTime DateOfCreation { get; set; }
        public DateTime DateOfModification { get; set; }
        
        public decimal Sum { get; set; }

        public static SaleEntity CreateFrom(Sale sale)
        {
            var builder = new SaleBuilder();
            builder
                .WithSum(sale.Sum)
                .WasCreatedAt(sale.DataOfCreation)
                .WasModifiedAt(sale.DateOfModification)
                .WithClient(clientBuilder =>
                    clientBuilder
                        .Called(sale.Client.DataOfUser.FirstName).WithLastName(sale.Client.DataOfUser.LastName)
                        .FromSource(new SourceEntity(sale.Client.DataOfUser.SourceId, sale.Client.Source.Name))
                        .WithId(sale.ClientId))
                .WithStatus(new StatusEntity() {Name = sale.StatusOfSale.Name, Id = sale.StatusOfSale.Id});
            return builder.Construct();
        }
    }
}