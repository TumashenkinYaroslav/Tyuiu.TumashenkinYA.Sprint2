using Tyuiu.TumashenkinYA.Sprint2.Task5.V6.Lib;
namespace Tyuiu.TumashenkinYA.Sprint2.Task5.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestFindCardNameAndValue()
        {
            DataService ds = new DataService();
            int value1 = 1;
            int value2 = 6;
            string res = ds.FindCardNameAndValue(value1, value2);
            string wait = "шестёрка пик";
            Assert.AreEqual(wait, res);
        }
    }
}
