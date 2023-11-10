using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ChazovaSR.Sprint4.Task5.V28.Lib;

namespace Tyuiu.ChazovaSR.Sprint4.Task5.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5]{ { 1,-6,1,-6,1, },
                                          { 1,-6,1,-6,1, },
                                          { 1,-6,1,-6,1,},
                                          { 1,-6,1,-6,1, },
                                          { 1,-6,1,-6,1, }};
            int[,] res = ds.Calculate(matrix);
            int[,] wait = new int[5, 5] { { 1,0,1,0,1, },
                                          { 1,0,1,0,1, },
                                          { 1,0,1,0,1, },
                                          { 1,0,1,0,1, },
                                          { 1,0,1,0,1, }};
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
