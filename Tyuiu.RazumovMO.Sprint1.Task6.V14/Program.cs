using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.RazumovMO.Sprint1.Task6.V14.Lib;

namespace Tyuiu.RazumovMO.Sprint1.Task6.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("Введите строку: ");
            string value = Console.ReadLine();
            Console.WriteLine(ds.CheckLowerCaseRusLetters(value));
            Console.ReadKey();

        }
    }
}
