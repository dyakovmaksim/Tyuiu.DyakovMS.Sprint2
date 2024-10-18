using Tyuiu.DyakovMS.Sprint2.Task6.V5.Lib;

namespace Tyuiu.DyakovMS.Sprint2.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestFindCardValue()
        {
            DataService ds = new DataService();
            int value = 6;
            string res = ds.FindCardValue(value);
            string wait = "шестёрка";
            Assert.AreEqual(wait, res);
        }
    }
}