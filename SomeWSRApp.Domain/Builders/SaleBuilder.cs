using System;
using SomeWSRApp.Domain.Layer.Entities;

namespace SomeWSRApp.Domain.Layer.Builders
{
    public class SaleBuilder : IEntityBuilder<SaleEntity>
    {
        protected readonly SaleEntity _entity;

        public SaleBuilder()
        {
            _entity = new SaleEntity();
        }

        public IEntityBuilder<SaleEntity> WithId(int id)
        {
            _entity.Id = id;
            return this;
        }

        public SaleBuilder WithClient(ClientEntity clientEntity)
        {
            _entity.Client = clientEntity;
            return this;
        }

        public SaleBuilder WasCreatedAt(DateTime date)
        {
            _entity.DateOfCreation = date;
            return this;
        }
        
        public SaleBuilder WasModifiedAt(DateTime date)
        {
            _entity.DateOfModification = date;
            return this;
        }

        public SaleBuilder WithSum(decimal sum)
        {
            _entity.Sum = sum;
            return this;
        }

        public SaleBuilder WithStatus(StatusEntity statusEntity)
        {
            _entity.Status = statusEntity;
            return this;
        }
        
        public SaleEntity Construct()
        {
            return _entity;
        }
    }
}