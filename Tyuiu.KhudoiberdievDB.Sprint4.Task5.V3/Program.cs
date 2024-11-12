
using System.Security.Cryptography;
using Tyuiu.KhudoiberdievDB.Sprint4.Task5.V3.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint4.Task5.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rndm = new Random();
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Худойбердиев Д. Б. | ИСПБ 24-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #4                                                                    *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                             *");
            Console.WriteLine("* Задание #5                                                                   *");
            Console.WriteLine("* Вариант #3                                                                   *");
            Console.WriteLine("* Выполнил: Худойбердиев Далер Бахритдинович | ИСПБ 24-1                       *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный случайными  *");
            Console.WriteLine("* значениями в диапазоне от -5 до 4. Заменить отрицательные элементы на 0.     *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");
            int[,] num = new int [5,5];
            int rows = 5
                , cols = 5;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    num[i, j] = rndm.Next(-5, 4);
                }

            }
            Console.WriteLine("\nМассив : ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{num[i, j]}   \t ");
                }
                Console.WriteLine();
            }


            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (num[i, j] < 0)
                    {
                        num[i, j] = 0;
                    }
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{num[i, j]}   \t ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();



        }
    }
}
