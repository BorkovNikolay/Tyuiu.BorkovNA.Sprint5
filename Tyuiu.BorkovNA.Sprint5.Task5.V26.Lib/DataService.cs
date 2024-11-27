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
            double res1 = 0;
            double res3 = 0;

            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] str = line.Split(' ');
                    foreach (string str2 in str)
                    {
                        string str3 = str2.Replace(".", ",");
                        if (Convert.ToDouble(str3) > 0)
                        {
                            
                            res = res + Convert.ToDouble(str3);
                        }
                        if (Convert.ToDouble(str3) < 0)
                        {

                            res1 = res1 + Convert.ToDouble(str3);
                        }
                        res3 = res - res1;
                    }
                }
            }
            res3 = Math.Round(res3,3);
            return res3;
        }
    }
}
