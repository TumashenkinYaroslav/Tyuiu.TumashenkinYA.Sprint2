using Tyuiu.TumashenkinYA.Sprint2.Task12.Lib;
namespace Tyuiu.TumashenkinYA.Sprint2.Task7.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            double y = 0.5, x = 1;
            var res = ds.CheckDotInShadedArea(x, y);
            Assert.IsTrue(res);
        }
    }
}
