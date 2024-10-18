using Tyuiu.DyakovMS.Sprint2.Task2.V12.Lib;

namespace Tyuiu.DyakovMS.Sprint2.Task2.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 4; 
            int y = 4;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(res, true);
        }
    }
}