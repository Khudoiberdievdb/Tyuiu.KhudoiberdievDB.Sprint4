using Tyuiu.KhudoiberdievDB.Sprint4.Task1.V9.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint4.Task1.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[] nums = { 6, 3, 3, 7, 7, 7, 7, 3, 3, 6, 4, 4, 8 };
            int res = ds.Calculate(nums);
            int wait = 4608;
            Assert.AreEqual(res, wait);
        }
    }
}