using SomeWSRApp.EF.Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeWSRApp.Domain.Layer.Configurations
{
    public interface IEntityConfiguration<T> where T: Entity
    {
        T Configure(T value);
    }
}
