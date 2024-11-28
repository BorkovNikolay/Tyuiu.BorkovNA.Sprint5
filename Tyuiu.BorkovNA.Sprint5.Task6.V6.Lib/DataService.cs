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
            int x = 0;
            string[] a = File.ReadAllText(path).Split(' ');
            foreach (string s in a)
            {
                for (int j = 0; j < s.Length; j++)
                {
                    if (char.IsLower(s[j]) && s[j] >= 'а' && s[j] <= 'я')
                    {
                        x++;
                    }
                }
            }
            return x;
        }
    }
}
