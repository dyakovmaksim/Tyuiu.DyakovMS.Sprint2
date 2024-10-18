using System.ComponentModel.Design;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.DyakovMS.Sprint2.Task2.V12.Lib
{
    public class DataService : ISprint2Task2V12
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            if (((x >= 3) && (x <= 5)) && (y >= 3) && (y <= 7))
            {
                res = true;
            } else if (((x >= 6) && (x <= 8)) && ((y >= 5) && (y <= 8)))
            {
                res = true;
            } else if (((x >= 9) && (x <= 12)) && (y >= 3) && (y <= 8))
            {
                res = true;
            } else if (((x >= 11) && (x <= 12)) && (y >= 9) && (y <= 12))
            {
                res = true;
            } else if ((x == 13) && (y >= 6) && (y <= 8))
            {
                res = true;
            } else if (((x >= 6) && (x <= 7) && (x == 7)) && ((y >= 9) && (y <= 11)))
            {
                res = true;
            } else if (((x >= 3) && (x <= 5)) && (y == 11))
            {
                res = true;
            } else { 
                res = false;
            }   
            return res;
        }
    }
}
