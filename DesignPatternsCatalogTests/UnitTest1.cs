using System;
using Strategy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsCatalogTests
{
    /*
     * Should I organize unit tests via folders( one for each Pattern ) or via files? 
     */
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var con = new Context(new ConcreteStrategyA());
            Assert.AreEqual(con.Execute(), "A");

            con = new Context(new ConcreteStrategyB());
            Assert.AreEqual(con.Execute(), "B");
        }
    }
}
