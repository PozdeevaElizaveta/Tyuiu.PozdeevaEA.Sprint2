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

            Assert.AreEqual("Январь",ds.FindMonthName(0,0));
            Assert.AreEqual("Февраль",ds.FindMonthName(0, 1));
            Assert.AreEqual("Март", ds.FindMonthName(0, 2));
            Assert.AreEqual("Апрель",ds.FindMonthName(0, 3));
            Assert.AreEqual("Май",  ds.FindMonthName(0, 4));
            Assert.AreEqual("Июнь",     ds.FindMonthName(0, 5));
            Assert.AreEqual("Июль", ds.FindMonthName(0, 6));
            Assert.AreEqual("Август", ds.FindMonthName(0, 7));
            Assert.AreEqual("Сентябрь", ds.FindMonthName(0, 8));
            Assert.AreEqual("Октябрь", ds.FindMonthName(0, 9));
            Assert.AreEqual("Ноябрь", ds.FindMonthName(0, 10));
            Assert.AreEqual("Декабрь", ds.FindMonthName(0, 11));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindMonthName(0, -1);

            });
           
        }
    }
}
