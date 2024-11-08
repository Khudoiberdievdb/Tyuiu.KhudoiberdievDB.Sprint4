using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KhudoiberdievDB.Sprint4.Task0.V23.Lib
{
    public class DataService : ISprint4Task0V23
    {
        public int GetMultOddArrEl(int[] array)
        {
            int res = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] %2 != 0)
                {
                    res *=array[i] ;
                }
            }
            return res;
        }
    }
}
