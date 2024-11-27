using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text;

namespace Tyuiu.BorkovNA.Sprint5.Task4.V23.Lib
{
    public class DataService : ISprint5Task4V23
    {
        public double LoadFromDataFile(string path)
        {
            double x = Convert.ToDouble(File.ReadAllText(path).Replace('.', ','));
            x = Math.Round(Math.Pow(x,-3)+2+Math.Cos(x), 3);
            return x;
        }
    }
}
