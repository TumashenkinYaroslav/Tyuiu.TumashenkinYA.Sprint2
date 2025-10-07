using Tyuiu.TumashenkinYA.Sprint2.Task2.V10.Lib;
namespace Tyuiu.TumashenkinYA.Sprint2.Task2.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 4, y = 4;
            bool wait = true;
            var res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(res, wait);
        }
    }
}
