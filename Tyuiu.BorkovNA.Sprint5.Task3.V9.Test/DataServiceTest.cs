using Tyuiu.BorkovNA.Sprint5.Task3.V9.Lib;

namespace Tyuiu.BorkovNA.Sprint5.Task3.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            string a = ds.SaveToFileTextData(3);
            Assert.AreEqual(true, new FileInfo(a).Exists);
        }
    }
}