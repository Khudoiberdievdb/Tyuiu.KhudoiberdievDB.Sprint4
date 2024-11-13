using Tyuiu.KhudoiberdievDB.Sprint4.Task7.V26.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint4.Task7.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string value = "351268459614723";
            int n = 5;
            int m = 3;
            int[,] nums = new int[n, m];
            int wait = 18432;
            int res = ds.Calculate(n, m, value);
            Assert.AreEqual(wait, res);
        }
    }
}