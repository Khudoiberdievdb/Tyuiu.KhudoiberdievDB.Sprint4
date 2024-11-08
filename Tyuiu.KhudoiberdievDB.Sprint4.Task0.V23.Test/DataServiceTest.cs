using Tyuiu.KhudoiberdievDB.Sprint4.Task0.V23.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint4.Task0.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[] num1 = { 9, 3, 7, 1, 5, 5, 3, 2, 1, 7 };
            var res = ds.GetMultOddArrEl(num1);
            int wait = 99225;
            Assert.AreEqual(res, wait);

        }
    }
}