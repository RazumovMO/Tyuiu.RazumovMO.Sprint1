using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.RazumovMO.Sprint1.Task0.V0.Lib;

namespace Tyuiu.RazumovMO.Sprint1.Task0.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExprssion()
        {
            DataService ds = new DataServiceTest();
            var res = ds.Calc();
        }
    }
}
