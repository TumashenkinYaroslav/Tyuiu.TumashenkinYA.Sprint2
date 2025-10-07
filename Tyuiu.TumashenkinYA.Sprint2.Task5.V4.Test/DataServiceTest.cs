using Tyuiu.TumashenkinYA.Sprint2.Task5.V4.Lib;
namespace Tyuiu.TumashenkinYA.Sprint2.Task5.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestFindCardNameAndValue()
        {
            DataService ds = new DataService();
            int value1 = 1;
            string res = ds.FindCardSuit(value1);
            string wait = "пик";
            Assert.AreEqual(wait, res);
        }
    }
}
