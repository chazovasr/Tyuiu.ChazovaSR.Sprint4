using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ChazovaSR.Sprint4.Task3.V21.Lib;

namespace Tyuiu.ChazovaSR.Sprint4.Task3.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 5]{ { 8,3,3,3,5 },
                                         { 6,7,3,3,7},
                                         { 4,5,4,6,6},
                                         { 5,5,8,8,7},
                                          { 4,6,6,7,7}};
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Чазова С.Р | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема:   Двумерные массивы. (статический ввод)                           *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнила: Чазова Софья Романовна | ИСТНб-23-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* значениями в диапазоне от 3 до 8. Найдите произведение элементов        *");
            Console.WriteLine("* в последнем столбце массива.( 8, 3, 3, 3, 5), (6, 7, 3, 3, 7),          *");
            Console.WriteLine("* (4, 5, 4, 6, 6) , (5, 5, 8, 8, 7), ( 4, 6, 6, 7, 7)                     *"); 
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(" Массив: ");
            for (int i=0; i<rows; i++)
            {
                for (int j=0; j<columns; j++)
                {
                    Console.WriteLine($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }
      

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(array);
            Console.WriteLine(" Произведение элементов в последнем столбце массива: " + res);

            Console.ReadKey();
        }
    }
}
