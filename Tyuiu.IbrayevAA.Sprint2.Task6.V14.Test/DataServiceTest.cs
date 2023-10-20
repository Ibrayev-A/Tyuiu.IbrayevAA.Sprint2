using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IbrayevAA.Sprint2.Task6.V14.Lib;

namespace Tyuiu.IbrayevAA.Sprint2.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual("понедельник", ds.FindDayName(1, 1));
            Assert.AreEqual("вторник", ds.FindDayName(2, 1));
            Assert.AreEqual("среда", ds.FindDayName(3, 1));
            Assert.AreEqual("четверг", ds.FindDayName(4, 1));
            Assert.AreEqual("пятница", ds.FindDayName(5, 1));
            Assert.AreEqual("суббота", ds.FindDayName(6, 1));
            Assert.AreEqual("воскресенье", ds.FindDayName(7, 1));




        }
    }
}
