using Tyuiu.KhudoiberdievDB.Sprint4.Task6.V11.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint4.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string[] anim = { "Кошка", "Собака", "Слон", "Жираф", "Бегемот", "Игуана", "Ягуар" };
            var res = ds.Calculate(anim);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}