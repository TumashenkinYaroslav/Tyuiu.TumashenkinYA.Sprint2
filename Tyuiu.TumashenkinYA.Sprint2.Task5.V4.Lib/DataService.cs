using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.TumashenkinYA.Sprint2.Task5.V4.Lib
{
    public class DataService : ISprint2Task5V4
    {
        public string FindCardSuit(int value)
        {
            string suit;


            switch (value)
            {
                case 1:
                    suit = "пик";
                    break;
                case 2:
                    suit = "треф";
                    break;
                case 3:
                    suit = "бубен";
                    break;
                case 4:
                    suit = "червей";
                    break;
                default:
                    throw new ArgumentException($"Масть карты должна быть от 1 до 4.Значение{value}");


            }
            return suit;
        }
    }
}

