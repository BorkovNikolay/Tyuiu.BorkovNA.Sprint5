using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Tyuiu.BorkovNA.Sprint5.Task6.V6.Lib
{
    public class DataService : ISprint5Task6V6
    {
        public int LoadFromDataFile(string path)
        {
            int i = 0, k = 0;
            string[] a = File.ReadAllText(path).Split(' ');
            foreach (string s in a)
            {
                if (Regex.IsMatch(s,"^[а-я]$"))
                {
                    i++;
                }
            }
            return i;
        }
    }
}
