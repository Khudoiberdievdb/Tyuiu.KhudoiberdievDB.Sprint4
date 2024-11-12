using System.Linq;
using System.Globalization;
using System.Numerics;
using tyuiu.cources.programming.interfaces.Sprint4;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
namespace Tyuiu.KhudoiberdievDB.Sprint4.Task3.V18.Lib
{
    public class DataService : ISprint4Task3V18
    {
        public int Calculate(int[,] array)
        {
            int[,] nums = new int[5, 5] { { 2, 4, 2, 7, 7 },
            {4, 7, 9, 9, 7 },
            {8, 5, 5, 6, 5 },
            {7, 7, 5, 2, 9 },
            {9, 3, 7, 9, 8 },}; 

            int max = 0;
            int raws = array.GetUpperBound(0) + 1;
            int columns = array.Length / raws;
            for (int i = 0; i < raws; i++)
                
            {
                if (raws < 4) { continue; }
                
                for (int j = 0; j < columns; j++)
                {
                   
                    if (nums[i,j] > max  )
                    {
                       max = nums[i,j];
                    }
                   

                }
                
            } return max;



        }
         
        

    }
}
