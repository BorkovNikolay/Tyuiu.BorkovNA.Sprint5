using Tyuiu.BorkovNA.Sprint5.Task0.V14.Lib;
using System.IO;


namespace Tyuiu.BorkovNA.Sprint5.Task0.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\nikmi\source\repos\Tyuiu.BorkovNA.Sprint5\Tyuiu.BorkovNA.Sprint5.Task0.V14\bin\Debug\net8.0\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
    }
}