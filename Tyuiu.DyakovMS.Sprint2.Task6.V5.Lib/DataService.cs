using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.DyakovMS.Sprint2.Task6.V5.Lib
{
    public class DataService : ISprint2Task6V5
    {
        public string FindCardValue(int value)
        {
            string rang;

            switch (value)
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
                    throw new ArgumentException($"Достоинство карты должно быть от 6 до 14.Значение{value}");
            }
            return rang;
        }
    }
}
