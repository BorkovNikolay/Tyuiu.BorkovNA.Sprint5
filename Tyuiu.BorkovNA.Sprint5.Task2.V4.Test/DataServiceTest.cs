using Tyuiu.BorkovNA.Sprint5.Task2.V4.Lib;

namespace Tyuiu.BorkovNA.Sprint5.Task2.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            int[,] n = { { 6, 9, 4 }, { 7, 2, 4 }, { 4, 8, 3 } };
            string a = ds.SaveToFileTextData(n);
            Assert.AreEqual(true, new FileInfo(a).Exists);
        }
    }
}