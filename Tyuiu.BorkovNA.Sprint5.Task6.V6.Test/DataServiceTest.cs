using Tyuiu.BorkovNA.Sprint5.Task6.V6.Lib;

namespace Tyuiu.BorkovNA.Sprint5.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            Assert.AreEqual(2, ds.LoadFromDataFile(Path.Combine("C:", "DataSprint5", "InPutDataFileTask6V24.txt")));
        }

    }
}