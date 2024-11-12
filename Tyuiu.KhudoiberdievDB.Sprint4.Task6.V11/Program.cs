using Tyuiu.KhudoiberdievDB.Sprint4.Task6.V11.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint4.Task6.V11
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
            Console.WriteLine("* Задание #6                                                                   *");
            Console.WriteLine("* Вариант #11                                                                    *");
            Console.WriteLine("* Выполнил: Худойбердиев Далер Бахритдинович | ИСПБ 24-1                       *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Дан строковый массив данных  используя класс Array подсчитайте количество    *");
            Console.WriteLine("* элементов, длина которых равна 5                                             *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Массив :");
            string[] anim = { "Кошка", "Собака", "Слон", "Жираф", "Бегемот", "Игуана", "Ягуар" };
            for (int i = 0; i < anim.Length; i++)
            {
                Console.Write($"{anim[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("количество элементов, длина которых равна 5 : " +ds.Calculate(anim));
            Console.ReadKey();
        }
    }
}
