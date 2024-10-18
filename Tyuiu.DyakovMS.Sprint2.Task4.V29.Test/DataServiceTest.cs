using Tyuiu.DyakovMS.Sprint2.Task4.V29.Lib;

namespace Tyuiu.DyakovMS.Sprint2.Task4.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 19;
            double wait = 231;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}