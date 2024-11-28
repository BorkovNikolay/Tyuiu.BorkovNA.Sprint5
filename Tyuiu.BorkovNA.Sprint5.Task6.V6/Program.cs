using System;
using Tyuiu.BorkovNA.Sprint5.Task6.V6.Lib;




namespace Tyuiu.BorkovNA.Sprint5.Task6.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Cпринт #5 | Выполнил: Борков Н. А. | пктб-24-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #5                                                                *");
            Console.WriteLine("* Тема: Операции сравнения                                                 *");
            Console.WriteLine("* Задание #6                                                               *");
            Console.WriteLine("* Вариант #6                                                               *");
            Console.WriteLine("* Выполнил: Борков Н. А. | пктб-24-1                                       *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");
            string path = @"C:\DataSprint5\InPutDataFileTask6V6.txt";
            Console.WriteLine("* Путь: " + path + " *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.LoadFromDataFile(path));
            Console.ReadKey();

        }
    }

}