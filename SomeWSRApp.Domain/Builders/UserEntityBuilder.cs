using SomeWSRApp.Domain.Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeWSRApp.Domain.Layer.Builders
{
    public class UserEntityBuilder : IEntityBuilder<UserEntity>
    {
        protected UserEntity _entity;

        public UserEntityBuilder ()
        {
            _entity = new UserEntity();
        }

        public UserEntityBuilder Called(string value)
        {
            _entity.FirstName = value;
            return this;
        }

        public UserEntityBuilder WithLastName(string value)
        {
            _entity.LastName = value;
            return this;
        }

        public UserEntityBuilder WithLogin(string value)
        {
            _entity.LastName = value;
            return this;
        }

        public UserEntityBuilder WithPassword(string value)
        {
            _entity.Password = value;
            return this;
        }

        public UserEntityBuilder WithRole(Role value)
        {
            _entity.Role = value;
            return this;
        }

        public UserEntity Construct()
        {
            return _entity;
        }

        public IEntityBuilder<UserEntity> WithId(int id)
        {
            _entity.Id = id;
            return this;
        }
    }
}
