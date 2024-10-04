using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.DyakovMS.Sprint2.Task0.V17.Lib
{
    public class DataService : ISprint2Task0V17
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] results =
            [
                (x > y), // True: 1065 > 755
                (x == y), // False: 1065 == 755
                (x < y), // False: 1065 < 755
                (x <= y), // False: 1065 <= 755
                (x >= y + 5000), // False: 1065 >= (755 + 5000)
                (x != y + 310), // FAlse: 1065 == (755 + 310)
            ];
            return results;
        }
    }
}
