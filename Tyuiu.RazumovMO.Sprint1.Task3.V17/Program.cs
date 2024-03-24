using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.RazumovMO.Sprint1.Task3.V17.Lib;

namespace Tyuiu.RazumovMO.Sprint1.Task3.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            double x = Convert.ToDouble(Console.ReadLine());

            Console.Title = "Спринт №0 | Выполнил: Разумов М. О. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт №1                                                               *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Разумов Максим Олегович | ПКТб-23-2                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая вычисялет выражение 5 * 2  *");
            Console.WriteLine("* + 4 * 3 и печатает результат на экране.                                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Введите число с тремя и менее цифрами после запятой, чтобы узнать, есть ли там \"0\" *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ: " + ds.ZeroCheck(x) + "                                                           *");
            Console.WriteLine("***************************************************************************");
            Console.ReadLine();
            Console.WriteLine(ds.ZeroCheck(x));

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
