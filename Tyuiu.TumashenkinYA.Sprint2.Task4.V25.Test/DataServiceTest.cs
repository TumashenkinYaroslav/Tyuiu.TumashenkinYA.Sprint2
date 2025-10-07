using Tyuiu.TumashenkinYA.Sprint2.Task4.V25.Lib;
namespace Tyuiu.TumashenkinYA.Sprint2.Task4.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 0;
            var res = ds.Calculate(x, y);
            double wait = 1;
            Assert.AreEqual(wait, res);
                
        }
    }
}
