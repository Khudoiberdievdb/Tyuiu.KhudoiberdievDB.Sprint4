using System.ComponentModel;
using Tyuiu.KhudoiberdievDB.Sprint4.Task2.V5.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint4.Task2.V5
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
            Console.WriteLine("* Задание #2                                                                   *");
            Console.WriteLine("* Вариант #5                                                                   *");
            Console.WriteLine("* Выполнил: Худойбердиев Далер Бахритдинович | ИСПБ 24-1                       *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов заполненный случайными   *");
            Console.WriteLine("* в диапазоне от 3 до 9 подсчитать произведение четных элементов массива.      *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine(" Введите количество элементов массива ");
            int len;
            len = Convert.ToInt32(Console.ReadLine());
            int[] num = new int[len];
            for (int i = 0; i < len; i++)
            {
                num[i] = rndm.Next(3, 9);   
            }
            Console.WriteLine("Массив : ");
            for (int i = 0;i < len; i++)
            {
                Console.WriteLine(num[i] + "\t");
            }
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine(" Произведение четных элементов массива = " + ds.Calculate(num));
            Console.ReadKey();

            
        }
    }
}
