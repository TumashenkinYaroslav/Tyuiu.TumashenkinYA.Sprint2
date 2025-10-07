using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.TumashenkinYA.Sprint2.Task2.V10.Lib
{
    public class DataService : ISprint2Task2V10
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            if ((y == 14) && (x > 1 && x < 7)) res = true;
            else if (y == 13 && x == 13) res = true;
            else if ((y == 12 || y == 10) && (x == 4 || x == 8 || x == 9)) res = true;
            else if (y == 11 && ((x > 2 && x < 6) || x == 8 || x == 9)) res = true;
            else if (y == 9 && (x == 4 || (x > 5 && x < 10))) res = true;
            else if (y == 8 && (x == 4 || (x > 5 && x < 14))) res = true;
            else if ((y == 7 || y == 6) && (x > 2 && x < 14)) res = true;
            else if (y == 5 && (x > 2 && x < 13)) res = true;
            else if ((y == 4 || y == 3) && ((x > 2 && x < 6)) || (x > 8 && x < 13)) res = true;
            else res = false;




                return res;
            
        }
    }
}
