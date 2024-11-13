using System;
using Tyuiu.KhudoiberdievDB.Sprint4.Task7.V26.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint4.Task7.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Худойбердиев Д. Б. | ИСПБ 24-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #4                                                                    *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                             *");
            Console.WriteLine("* Задание #7                                                                   *");
            Console.WriteLine("* Вариант #26                                                                  *");
            Console.WriteLine("* Выполнил: Худойбердиев Далер Бахритдинович | ИСПБ 24-1                       *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Дана строка из одноразрядных цифр \"351268459614723\". Преобразуйте ее в     *");
            Console.WriteLine("* матрицу 5 на 3 и подсчитайте произведение четных чисел.                      *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");
            string value = "351268459614723";
            int n = 5;
            int m = 3;
            int[,] nums = new int[n, m];
            Console.WriteLine(" Массив :");
            int index = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    nums[i, j] = int.Parse(value.Substring(index, 1));
                    index++;
                }
            }





            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{nums[i,j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Произведение четных чисел = " +ds.Calculate(n,m,value));
            Console.ReadKey();

        }
    }
}
