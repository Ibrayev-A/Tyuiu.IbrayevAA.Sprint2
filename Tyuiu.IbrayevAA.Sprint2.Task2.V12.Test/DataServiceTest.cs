using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IbrayevAA.Sprint2.Task2.V12.Lib;

namespace Tyuiu.IbrayevAA.Sprint2.Task2.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 4;
            int y = 4;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
