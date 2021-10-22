using AbstractFactory.Entities;
using AbstractFactory.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestConcepts
{
    [TestClass]
    public class AbstractFactoryTest
    {
        [TestMethod]
        public void MonTest()
        {
            var factory = new PeugeotFactory();
            var roadster = factory.CreateRoadster();
            Assert.IsInstanceOfType(roadster, typeof(PeugeotRoadster));
        }
    }
}