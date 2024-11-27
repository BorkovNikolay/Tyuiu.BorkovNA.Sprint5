using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text;


namespace Tyuiu.BorkovNA.Sprint5.Task5.V26.Lib
{
    public class DataService : ISprint5Task5V26
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;

            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] str = line.Split(',');
                    foreach (string str2 in str)
                    {
                        if (Convert.ToDouble(str2) % 2 == 0)
                        {
                            string str3 = str2.Replace(".", ",");
                            res = res + Convert.ToDouble(str2);
                        }
                    }
                }
            }
            res = Math.Round(res,3);
            return res;
        }
    }
}
