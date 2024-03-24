using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.RazumovMO.Sprint1.Task6.V14.Lib;

namespace Tyuiu.RazumovMO.Sprint1.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string aboba = "адавыдыфдадфды";
            string oboba = "ААппААппААпп";

            var res1 = ds.CheckLowerCaseRusLetters(aboba);
            var res2 = ds.CheckLowerCaseRusLetters(oboba);

            Assert.AreEqual(res1 , true);
            Assert.AreEqual(res2, false);

        }
    }
}
