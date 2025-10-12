using Tyuiu.PozdeevaEA.Sprint2.Task5.V7.Lib;
namespace Tyuiu.PozdeevaEA.Sprint2.Task5.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindMonthName()
        {
            DataService ds = new DataService();

            Assert.AreEqual("январь",ds.FindMonthName(0,0));
            Assert.AreEqual("февраль",ds.FindMonthName(0, 1));
            Assert.AreEqual("март", ds.FindMonthName(0, 2));
            Assert.AreEqual("апрель",ds.FindMonthName(0, 3));
            Assert.AreEqual("май",  ds.FindMonthName(0, 4));
            Assert.AreEqual("июнь",     ds.FindMonthName(0, 5));
            Assert.AreEqual("июль", ds.FindMonthName(0, 6));
            Assert.AreEqual("август", ds.FindMonthName(0, 7));
            Assert.AreEqual("сентябрь", ds.FindMonthName(0, 8));
            Assert.AreEqual("октябрь", ds.FindMonthName(0, 9));
            Assert.AreEqual("ноябрь", ds.FindMonthName(0, 10));
            Assert.AreEqual("декабрь", ds.FindMonthName(0, 11));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindMonthName(0, -1);

            });
           
        }
    }
}
