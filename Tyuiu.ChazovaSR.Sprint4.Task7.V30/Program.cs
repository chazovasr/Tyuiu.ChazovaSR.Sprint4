using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ChazovaSR.Sprint4.Task7.V30.Lib;

namespace Tyuiu.ChazovaSR.Sprint4.Task7.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int m = 3;
            int[,] mtrx = new int[n, m];
            string str = "684259137159648";

            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Чазова С.Р | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема:   Добавление к решению итоговых проектов по спринту               *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнила: Чазова Софья Романовна | ИСТНб-23-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Дана строка из одноразрядных цифр '684259137159648'. Преобразуйте       *");
            Console.WriteLine("* ее в матрицу 5 на 3 и подсчитайте произведение четных чисел.            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int index = 0;

            Console.WriteLine("\nМассив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{str[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(n,m,str);
            Console.WriteLine("  Произведение четных чисел: " + res);
            Console.ReadKey();
        }
    }
}
