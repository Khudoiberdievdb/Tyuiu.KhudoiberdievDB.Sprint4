using System.Runtime.Intrinsics.Arm;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KhudoiberdievDB.Sprint4.Task4.V1.Lib
{
    public class DataService : ISprint4Task4V1
    {
        public int Calculate(int[,] matrix)
        {
            int raws = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / raws;
            int sum = 0;
             for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < raws; j++) 
                    if (matrix[i, j] % 2 ==0)
                    {
                        sum += matrix[i, j];
                    }
            } return sum;
        } 
    }
}
