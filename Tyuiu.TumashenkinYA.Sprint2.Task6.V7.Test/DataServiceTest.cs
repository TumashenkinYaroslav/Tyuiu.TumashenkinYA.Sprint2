using Tyuiu.TumashenkinYA.Sprint2.Task6.V7.Lib;
namespace Tyuiu.TumashenkinYA.Sprint2.Task6.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestFindMonthName()
        {
            DataService ds = new DataService();
            int n = 1, MSY = 1;
            string wait = "Февраль";
            var res = ds.FindMonthName(MSY, n);
            Assert.AreEqual(wait, res);
           
        }
    }
}
