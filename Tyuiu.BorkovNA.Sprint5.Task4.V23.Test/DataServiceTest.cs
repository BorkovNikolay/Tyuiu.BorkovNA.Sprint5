using Tyuiu.BorkovNA.Sprint5.Task4.V23.Lib;

namespace Tyuiu.BorkovNA.Sprint5.Task4.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            Assert.AreEqual(3.591, ds.LoadFromDataFile(Path.Combine("C:", "DataSprint5", "InPutDataFileTask4V3.txt")));
        }
    }
}