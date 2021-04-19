using NUnit.Framework;
using SomeWSRApp.EF.Layer;

namespace SomeWSRApp.EF.Tests
{
    public class DummyDataBase
    { 
    }
    
    public class EntityContextOfTests
    {
        private IEntitiesContext entities;
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}