using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.BorkovNA.Sprint5.Task2.V4.Lib
{
    public class DataService : ISprint5Task2V4
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string a = Path.GetTempFileName();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > 0) { matrix[i, j] = 1; }
                    if (matrix[i, j] < 0) { matrix[i, j] = 0; }
                    if (j != matrix.GetLength(1) - 1) { File.AppendAllText(a, Convert.ToString(matrix[i, j]) + ";"); }
                    else { File.AppendAllText(a, Convert.ToString(matrix[i, j])); }
                }
                File.AppendAllText(a, "\n");
            }



            return a;
        }
    }
}
