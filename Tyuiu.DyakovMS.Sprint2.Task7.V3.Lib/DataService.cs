﻿using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.DyakovMS.Sprint2.Task7.V3.Lib
{
    public class DataService : ISprint2Task7V3
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res = false;
            if ((Math.Pow(x,2) + Math.Pow(y-1, 2) <= 1) && (y <= (1 - Math.Pow(x, 2))))
            {
                res = true;
            }
            return res;
        }
    }
}
