using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.RazumovMO.Sprint1.Task2.V30.Lib;

namespace Tyuiu.RazumovMO.Sprint1.Task2.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            var res = ds.ConvertKmToMetre(x);
            Assert.AreEqual(2000, res);

        }
    }
}
