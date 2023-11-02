using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ChazovaSR.Sprint4.Task2.V11.Lib;

namespace Tyuiu.ChazovaSR.Sprint4.Task2.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] array = { 7, 6, 3, 8, 5, 7, 6, 7, 6, 5, 4,8, 5, 5, 6 };
            int res = ds.Calculate(array);
            int wait = 44;
            Assert.AreEqual(wait, res);
        }
    }
}
