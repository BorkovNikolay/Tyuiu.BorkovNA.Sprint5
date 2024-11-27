using Tyuiu.BorkovNA.Sprint5.Task5.V26.Lib;

namespace Tyuiu.BorkovNA.Sprint5.Task5.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool file = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, file);
        }
    }
}