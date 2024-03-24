using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.RazumovMO.Sprint1.Task3.V17.Lib;

namespace Tyuiu.RazumovMO.Sprint1.Task3.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1.0250;
            double y = 1.9999;
            var res = ds.ZeroCheck(x);
            var res2 = ds.ZeroCheck(y);
            Assert.AreEqual(true, res);
            Assert.AreEqual(false, res2);
        }
    }
}
