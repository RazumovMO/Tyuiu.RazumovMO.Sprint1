using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.RazumovMO.Sprint1.Task7.V14.Lib;

namespace Tyuiu.RazumovMO.Sprint1.Task7.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 2;
            var res = ds.Calculate(x, y);
            var res2 = ds.Cut(res);
            Assert.AreEqual(224, res);
            Assert.AreEqual(224, res2);


        }
    }
}
