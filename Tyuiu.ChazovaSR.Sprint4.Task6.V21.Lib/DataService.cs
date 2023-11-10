using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ChazovaSR.Sprint4.Task6.V21.Lib
{
    public class DataService : ISprint4Task6V21
    {
        public int Calculate(string[] array)
        {
            string[] matrix = Array.FindAll(array, x => x.Length < 8);
            return matrix.Length;
        }
    }
}
