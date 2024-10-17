using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.DyakovMS.Sprint2.Task1.V5.Lib
{
    public class DataService : ISprint2Task1V5
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] result =
            [
                (a == b | c != d),  
                (a >= b & b < d),
                (a > b || c >= d),  
                (a != c && b < d), 
                (!(a < c) ^ (b <= d)), 
                (a <= b && c > d),
            ];
            return result;
        }
    }
}
