using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.TumashenkinYA.Sprint2.Task3.V15.Lib
{
    public class DataService : ISprint2Task3V15
    {
        public double Calculate(double x)
        {
            double y = new double();
            if (x > 1) y = x + Math.Pow((x + 1) / (x - 1), x);
            else if (x == 0) y = (0 - Math.Cos(x) + 10) / (0 - Math.Sin(x) + 12);
            else if (-19 < x && x < 2) y = Math.Pow(1 + 1 / (x * x), 8);
            else y = x + 10 * x - (1 / x);
            return Math.Round(y, 3);
        }
    }
}
