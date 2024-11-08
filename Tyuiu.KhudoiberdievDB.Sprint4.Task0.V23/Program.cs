using Tyuiu.KhudoiberdievDB.Sprint4.Task0.V23.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint4.Task0.V23
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
            Console.WriteLine("* Задание #0                                                                   *");
            Console.WriteLine("* Вариант #23                                                                  *");
            Console.WriteLine("* Выполнил: Худойбердиев Далер Бахритдинович | ИСПБ 24-1                       *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный статическими *");
            Console.WriteLine("* значениями в диапазоне от 0 до 9 подсчитать произведение нечетных элементов  *");
            Console.WriteLine("* массива. {9 ,3 ,7 ,1 ,5 ,5 ,3 ,2 ,1 ,7}                                      *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");
            int[] num1 = { 9, 3, 7, 1, 5, 5, 3, 2, 1, 7 };
            Console.WriteLine("Элементы массива : ");
                for (int i = 0; i<num1.Length; i++)
            {
                Console.WriteLine(num1[i]);
            }
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine(" Произведение нечетных элементов массива = " +ds.GetMultOddArrEl(num1));
            Console.ReadKey();
        }
    }
}
