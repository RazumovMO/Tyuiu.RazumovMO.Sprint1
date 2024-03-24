using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.RazumovMO.Sprint1.Task1.V1.Lib;

namespace Tyuiu.RazumovMO.Sprint1.Task1.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            double x, y, a;

            Console.WriteLine("Введите значение х: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение у: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение а: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Title = "Спринт №0 | Выполнил: Разумов М. О. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт №1                                                               *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Разумов Максим Олегович | ПКТб-23-2                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу, которая вычисялет значение выражения     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  (x / 3 / y) + 6 * a                                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ: " + ds.Calculate(x , y , a) + "                                                           *");
            Console.WriteLine("***************************************************************************");
            

           

            Console.ReadLine();
        }
    }
}
