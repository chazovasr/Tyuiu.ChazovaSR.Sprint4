using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ChazovaSR.Sprint4.Task1.V17.Lib;

namespace Tyuiu.ChazovaSR.Sprint4.Task1.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] array = { 1,7,6,3,2,5,7,6,7,6,5,4,7,6};
            int res = ds.Calculate(array);
            int wait = 30;
            Assert.AreEqual(wait, res);
        }
    }
}
