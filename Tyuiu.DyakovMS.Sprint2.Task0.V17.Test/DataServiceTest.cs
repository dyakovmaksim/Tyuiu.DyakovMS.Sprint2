using Tyuiu.DyakovMS.Sprint2.Task0.V17.Lib;

namespace Tyuiu.DyakovMS.Sprint2.Task0.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            bool[] results = ds.GetCompareOperations(1065, 755);
            Assert.AreEqual("True, False, False, False, False, False", String.Join(", ", results));
        }
    }
}