using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ChazovaSR.Sprint4.Task0.V12.Lib;

namespace Tyuiu.ChazovaSR.Sprint4.Task0.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultEvenArrEl()
        {
            DataService ds = new DataService();
            int[] array = { 4, 6, 2, 8, 4, 5, 6, 9, 8, 7, };
            int res = ds.GetMultEvenArrEl(array);
            int wait = 73728;
            Assert.AreEqual(wait, res);
        }
    }
}
