using Microsoft.VisualStudio.TestTools.UnitTesting;
using Singleton;

namespace TestConcepts
{
    [TestClass]
    public class SingletonTest
    {
        [TestMethod]
        public void ItReturnsASingleInstance()
        {
            var singleton1 = Singletonn.GetInstance();
            var singleton2 = Singletonn.GetInstance();

            Assert.AreEqual(singleton1, singleton2);
        }
    }
}