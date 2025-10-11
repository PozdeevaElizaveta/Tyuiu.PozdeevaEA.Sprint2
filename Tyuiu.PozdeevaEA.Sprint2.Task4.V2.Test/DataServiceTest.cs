using Tyuiu.PozdeevaEA.Sprint2.Task4.V2.Lib;
namespace Tyuiu.PozdeevaEA.Sprint2.Task4.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 8;
            double y = 3;
            double res = ds.Calculate(x, y);
            double wait = 11;
            Assert.AreEqual(res, wait);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 6;
            double res = ds.Calculate(x, y);
            double wait = 1.375;
            Assert.AreEqual(res, wait);
        }
    }
}
