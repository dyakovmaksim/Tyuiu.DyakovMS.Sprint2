using Tyuiu.DyakovMS.Sprint2.Task5.V6.Lib;

namespace Tyuiu.DyakovMS.Sprint2.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestFindCardNameAndValue()
        {
            DataService ds = new DataService();
            int value1 = 1;
            int value2 = 6;
            string res = ds.FindCardNameAndValue(value1, value2);
            string wait = "пики шестёрка";
            Assert.AreEqual(wait, res);
        }
    }
}