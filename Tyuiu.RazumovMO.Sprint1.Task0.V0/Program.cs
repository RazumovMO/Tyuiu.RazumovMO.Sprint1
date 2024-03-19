using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.RazumovMO.Sprint1.Task0.V0.Lib;

namespace Tyuiu.RazumovMO.Sprint1.Task0.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int Answer = 5 * 2 + 4 * 3;
            Console.WriteLine(Answer);
            DataService ds = new DataService();

            Console.Title = "Спринт №0 | Выполнил: Разумов М. О. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт №0                                                               *");
            Console.WriteLine("* Тема: Создание итогового решщения по спринту                            *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Разумов Максим Олегович | ПКТб-23-2                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая вычисялет выражение 5 * 2  *");
            Console.WriteLine("* + 4 * 3 и печататет результат на экране.                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  5 * 2 + 4 * 3                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate());
            Console.ReadLine();
        }
    }
}
