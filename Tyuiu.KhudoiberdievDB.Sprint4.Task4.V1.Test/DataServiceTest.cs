using System.ComponentModel;
using Tyuiu.KhudoiberdievDB.Sprint4.Task4.V1.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint4.Task4.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds  = new DataService();
            int[,] NUM = new int[,] { { 2, 5, 1, 7, 5 }, { 4, 4, 7, 4, 4 }, { 7, 1, 6, 8, 8 }, { 8, 1, 5, 8, 4 }, { 8, 9, 1, 7, 3 } };
            int res = ds.Calculate(NUM);
            int wait = 68;
            Assert.AreEqual(res, wait);
        }
    }
}