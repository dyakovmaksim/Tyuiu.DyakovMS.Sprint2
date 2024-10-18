using Tyuiu.DyakovMS.Sprint2.Task7.V3.Lib;

namespace Tyuiu.DyakovMS.Sprint2.Task7.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(false, res);
        }
    }
}