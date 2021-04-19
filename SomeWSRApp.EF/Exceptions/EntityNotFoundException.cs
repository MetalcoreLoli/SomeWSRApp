using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeWSRApp.EF.Layer.Exceptions
{
    public class EntityNotFoundException: Exception
    {
        public EntityNotFoundException(string nameofEntity)
            : base ($"Entity {nameofEntity} was not found")
        {
        }
    }
}
