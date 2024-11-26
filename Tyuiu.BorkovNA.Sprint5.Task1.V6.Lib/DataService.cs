using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.BorkovNA.Sprint5.Task1.V6.Lib
{
    public class DataService : ISprint5Task1V6
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string file = Path.GetTempFileName();
            if (File.Exists(file)) { File.Delete(file); }

            for (int i = startValue; i <= stopValue; i++)
            {
                if (i != stopValue)
                {
                    File.AppendAllText(file, Convert.ToString(Math.Round((Math.Cos(i)+((4*i)/2)-Math.Sin(i)*(3*i)), 2)) + "\n");
                }
                else { File.AppendAllText(file, Convert.ToString(Math.Round((Math.Cos(i) + ((4 * i) / 2) - Math.Sin(i) * (3 * i)), 2))); }
            }

            return file;
        }
    }
}
