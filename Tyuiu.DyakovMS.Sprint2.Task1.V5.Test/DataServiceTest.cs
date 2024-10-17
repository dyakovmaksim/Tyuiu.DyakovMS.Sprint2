using Tyuiu.DyakovMS.Sprint2.Task1.V5.Lib;

namespace Tyuiu.DyakovMS.Sprint2.Task1.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetLogicOperations()
        {
            int a = 154, b = 163, c = 134, d = 137;
            DataService ds = new DataService();
            bool[] results = ds.GetLogicOperations(a, b, c, d);
            Assert.AreEqual("True, False, False, False, True, False", String.Join(", ", results));
        }
    }
}