using System;
using System.Collections.Generic;
using SomeWSRApp.Domain.Layer.Entities;
using SomeWSRApp.EF.Layer;

namespace SomeWSRApp.Domain.Layer.Factories
{
    public class EntityFactory
    {
        private readonly IEntitiesContext _context;

        public EntityFactory(IEntitiesContext context)
        {
            _context = context;
        }

        public IEnumerable<SaleEntity> FromContext()
        {
            throw new NotImplementedException();
        }
    }
}