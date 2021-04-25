using System;
using SomeWSRApp.Domain.Layer.Entities;

namespace SomeWSRApp.Domain.Layer.Builders
{
    public class ClientEntityBuilder : IEntityBuilder<ClientEntity>
    {
        protected readonly ClientEntity _clientEntity;

        public ClientEntityBuilder()
        {
            _clientEntity = new ClientEntity();
        }
        public IEntityBuilder<ClientEntity> WithId(int id)
        {
            _clientEntity.Id = id;
            return this;
        }

        public ClientEntityBuilder Called(string name)
        {
            _clientEntity.Name = name;
            return this;
        }

        public ClientEntityBuilder WithLastName(string lastName)
        {
            _clientEntity.LastName = lastName;
            return this;
        }

        public ClientEntityBuilder FromSource(SourceEntity source)
        {
            _clientEntity.Source = source;
            return this;
        }

        public ClientEntity Construct()
        {
            return _clientEntity;
        }
    }

    public class SaleBuilder : IEntityBuilder<SaleEntity>
    {
        protected SaleEntity _entity;

        public SaleBuilder()
        {
            _entity = new SaleEntity();
        }

        public IEntityBuilder<SaleEntity> WithId(int id)
        {
            _entity.Id = id;
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

        public SaleBuilder WithClient(Func<ClientEntityBuilder, IEntityBuilder<ClientEntity>> builder)
        {
            _entity.Client = builder(new ClientEntityBuilder()).Construct();
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