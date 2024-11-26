using System;
using Tyuiu.BorkovNA.Sprint5.Task1.V6.Lib;




namespace Tyuiu.BorkovNA.Sprint4.Task0.V20
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
            Console.WriteLine("* Задание #1                                                               *");
            Console.WriteLine("* Вариант #6                                                               *");
            Console.WriteLine("* Выполнил: Борков Н. А. | пктб-24-1                                       *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");
            int x = -5;
            int y = 5;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            string res = ds.SaveToFileTextData(x,y);
            Console.WriteLine("Файл" + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();

        }
    }

}