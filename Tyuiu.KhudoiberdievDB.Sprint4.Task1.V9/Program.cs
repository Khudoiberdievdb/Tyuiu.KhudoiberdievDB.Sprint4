using Tyuiu.KhudoiberdievDB.Sprint4.Task1.V9.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint4.Task1.V9
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
            Console.WriteLine("* Подсчитать произведение четных элементов массива                             *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");
            int len;
            Console.WriteLine("Введите количество элементов массива");
            len = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int [len];
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("Введите " + i +" элемент значения массива  ");
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Массив : ");
            for (int i = 0;i < len; i++)
            {
                Console.WriteLine(nums[i] + "\t");
            }
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine(" Произведение четных элементов массива = " + ds.Calculate(nums));
            Console.ReadKey();

        }
    }
}
