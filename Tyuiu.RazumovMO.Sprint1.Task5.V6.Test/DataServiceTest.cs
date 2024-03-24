using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.RazumovMO.Sprint1.Task5.V6.Lib;

namespace Tyuiu.RazumovMO.Sprint1.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int k = 305;
            var res = ds.Calculate(k);
            Assert.AreEqual(res , 5);
        }
    }
}
