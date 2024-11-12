using Tyuiu.KhudoiberdievDB.Sprint4.Task5.V3.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint4.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[,] num = {{1,2,-3,4,-5 }, {-2,-1,3,3,3}, {1,2,-2,4,-3}, {1,2,3,2,1}, {2,-2,2,-2,-1 } };
            int[,] res = ds.Calculate(num);
            int[,] wait = { { 1, 2, 0, 4, 0 }, { 0, 0, 3, 3, 3 }, { 1, 2, 0, 4, 0 }, { 1, 2, 3, 2, 1 }, { 2, 0, 2, 0, 0 } };
            CollectionAssert.AreEqual(res, wait);
        }

    }
}