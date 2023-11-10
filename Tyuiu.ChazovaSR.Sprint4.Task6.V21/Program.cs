using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ChazovaSR.Sprint4.Task6.V21.Lib;

namespace Tyuiu.ChazovaSR.Sprint4.Task6.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Чазова С.Р | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема:   Класс Array                                                     *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнила: Чазова Софья Романовна | ИСТНб-23-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Дан строковый массив данных (Facebook, Twitter, Instagram, LinkedIn,    *");
            Console.WriteLine("* Pinterest, Reddit) используя класс Array подсчитайте количество         *");
            Console.WriteLine("* элементов, длина которых меньше 8.                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            var network = new string[] { "Facebook", "Twitter", "Instagram", "Snapchat", "LinkedIn", "Pinterest", "Reddit" };


            Console.WriteLine("Массив:");
            for (int i = 0; i <= network.Length-1; i++)
            {
             
                Console.WriteLine(network[i]);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Количество элементов, длина которых меньше 8 =  ");

            int nums = ds.Calculate(network);
            Console.WriteLine(nums);
            

            Console.ReadKey();
        }
    }
}
