using System.Security.Cryptography;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KhudoiberdievDB.Sprint4.Task7.V26.Lib
{
    public class DataService : ISprint4Task7V26
    {
        public int Calculate(int n, int m, string value)
        {
           
            int[,] nums = new int[n, m];
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    nums[i,j] = int.Parse(value.Substring(index,1));
                    index++;
                }
            }
            int res = 1;
            for (int i = 0;i < n; i++)
            {
                for (int j = 0;j < m; j++)
                {
                    if (nums[i,j]%2==0)
                    {
                        res *= nums[i, j];
                    }
                }
            }
            return res;

            
        

        }
    }
}
