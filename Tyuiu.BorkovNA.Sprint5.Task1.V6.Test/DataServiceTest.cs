using Tyuiu.BorkovNA.Sprint5.Task1.V6.Lib;

namespace Tyuiu.BorkovNA.Sprint5.Task1.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            string a = ds.SaveToFileTextData(-5, 5);
            FileInfo fileInfo = new FileInfo(a);
            Assert.AreEqual(true, fileInfo.Exists);
        }
    }
}