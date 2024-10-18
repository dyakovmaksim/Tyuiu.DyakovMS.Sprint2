using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.DyakovMS.Sprint2.Task5.V6.Lib
{
    public class DataService : ISprint2Task5V6
    {
        public string FindCardNameAndValue(int value1, int value2)
        {
            string suit;
            string rang;

            switch (value1)
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
                    throw new ArgumentException($"Масть карты должна быть от 1 до 4.Значение{value1}");
            }

            switch (value2)
            {
                case 6:
                    rang = "шестёрка";
                    break;
                case 7:
                    rang = "семёрка";
                    break;
                case 8:
                    rang = "восьмёрка";
                    break;
                case 9:
                    rang = "девятка";
                    break;
                case 10:
                    rang = "десятка";
                    break;
                case 11:
                    rang = "валет";
                    break;
                case 12:
                    rang = "дама";
                    break;
                case 13:
                    rang = "король";
                    break;
                case 14:
                    rang = "туз";
                    break;
                default:
                    throw new ArgumentException($"Достоинство карты должно быть от 6 до 14.Значение{value2}");
            }
            return $"{rang} {suit}";
        }
    }
}