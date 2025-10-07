using Tyuiu.TumashenkinYA.Sprint2.Task3.V15.Lib;
namespace Tyuiu.TumashenkinYA.Sprint2.Task3.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 0.75;
            Assert.AreEqual(wait, res);
        }
    }
}
