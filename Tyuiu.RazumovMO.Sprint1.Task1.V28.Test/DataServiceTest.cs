using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.RazumovMO.Sprint1.Task1.V1.Lib;

namespace Tyuiu.RazumovMO.Sprint1.Task1.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 6.0;
            double y = 0.5;
            double a = 6.0;
            var res = ds.Calculate(x, y, a);
            Assert.AreEqual(40 , res);
;        }
    }
}
