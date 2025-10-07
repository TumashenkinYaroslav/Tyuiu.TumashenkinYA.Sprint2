using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.TumashenkinYA.Sprint2.Task1.V11.Lib
{
    public class DataService : ISprint2Task1V11
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res =
                [
                (a == c | d >= b),
                (a == b & c == d),
                (a != d || c >= d),
                (a != b && c <= d),
                !(a == c),
                (a < b) ^ (c > d)
                ];
            return res;
        }
    }
}
