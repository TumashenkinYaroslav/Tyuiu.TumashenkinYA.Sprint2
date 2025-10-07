using Tyuiu.TumashenkinYA.Sprint2.Task1.V11.Lib;
namespace Tyuiu.TumashenkinYA.Sprint2.Task1.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCompareOperations()
        {
            DataService ds = new DataService();
            int a = 145, b = 156, c = 142, d = 117;
            var res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] { false, false, true, false, true, false };

            CollectionAssert.AreEqual(wait, res);

        }
    }
}
