using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.RazumovMO.Sprint1.Task4.V15.Lib;

namespace Tyuiu.RazumovMO.Sprint1.Task4.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x , y;
            x = 0.75;
            y = 0.5;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1 , res);
        }
    }
}
