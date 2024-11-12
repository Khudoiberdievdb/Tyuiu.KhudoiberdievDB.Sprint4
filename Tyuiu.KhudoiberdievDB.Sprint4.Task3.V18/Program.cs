using Tyuiu.KhudoiberdievDB.Sprint4.Task3.V18.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #4 | Выполнил: Худойбердиев Д. Б. | ИСПБ 24-1";
Console.WriteLine("********************************************************************************");
Console.WriteLine("* Спринт #4                                                                    *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                             *");
Console.WriteLine("* Задание #3                                                                   *");
Console.WriteLine("* Вариант #18                                                                  *");
Console.WriteLine("* Выполнил: Худойбердиев Далер Бахритдинович | ИСПБ 24-1                       *");
Console.WriteLine("********************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                     *");
Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный статическими*");
Console.WriteLine("* значениями в диапазоне от 2 до 9. Найдите максимальный элемент в последней   *");
Console.WriteLine("* строке массива                                                               *");
Console.WriteLine("********************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
Console.WriteLine("********************************************************************************");
Console.WriteLine("* Массив : *");
int[,] nums = new int[5, 5] { { 2, 4, 2, 7, 7 },
            {4, 7, 9, 9, 7 },
            {8, 5, 5, 6, 5 },
            {7, 7, 5, 2, 9 },
            {9, 3, 7, 9, 8 },};
int raws = nums.GetUpperBound(0) + 1;
int columns = nums.Length / raws;
for (int i = 0; i < columns; i++)
{
    for (int j = 0; j < raws; j++)
    {
        Console.Write($"{nums[i, j]}  \t");
    }
    Console.WriteLine();
}
Console.WriteLine("********************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
Console.WriteLine("********************************************************************************");
Console.WriteLine("Максимальный элемент в последней строке массива : " + ds.Calculate(nums));
Console.ReadKey();
