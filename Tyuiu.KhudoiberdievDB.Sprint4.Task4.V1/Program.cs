using System.Security.AccessControl;
using Tyuiu.KhudoiberdievDB.Sprint4.Task4.V1.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint4.Task4.V1
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
            Console.WriteLine("* Задание #4                                                                   *");
            Console.WriteLine("* Вариант #1                                                                   *");
            Console.WriteLine("* Выполнил: Худойбердиев Далер Бахритдинович | ИСПБ 24-1                       *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный значениями  *");
            Console.WriteLine("* с клавиатуры в диапазоне от 1 до 9. Найдите сумму четных элементов массива.  *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Введите количество строк в массиве : ");
            int raws = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов в массиве : ");
            int columns = Convert.ToInt32(Console.ReadLine());
            int[,] NUM = new int[raws, columns];
            Console.WriteLine("********************************************************************************");
            for (int i = 0; i < raws; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                     
                    Console.Write($"Введите значение {i},{j} элемента массива от 1 до 9 : ");
                    
                     NUM[i, j] = Convert.ToInt32(Console.ReadLine()); 
                    
                }
            }
            Console.WriteLine("\nМассив : ");
            for ( int i = 0;i < raws; i++)
            {
                for (int j = 0;j < columns; j++)
                {
                    Console.Write($"{NUM[i,j]}  \t");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Сумма всех четных элементов массива равна = " + ds.Calculate(NUM));
            Console.ReadKey();
        }
    }
}
