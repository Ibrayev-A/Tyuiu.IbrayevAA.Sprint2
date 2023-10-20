using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IbrayevAA.Sprint2.Task7.V9.Lib;

namespace Tyuiu.IbrayevAA.Sprint2.Task7.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 0.3;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
