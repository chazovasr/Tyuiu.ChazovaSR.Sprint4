using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ChazovaSR.Sprint4.Task2.V3.Lib;

namespace Tyuiu.ChazovaSR.Sprint4.Task2.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void VallidCalculate()
        {
            DataService ds = new DataService();
            int[] array = {  7, 6, 3, 2, 5, 7, 6, 7, 6, 5, 4 };
            int res = ds.Calculate(array);
            int wait = 24;
            Assert.AreEqual(wait, res);
        }
    }
}
