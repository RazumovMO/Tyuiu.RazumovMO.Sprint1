using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.RazumovMO.Sprint1.Task4.V15.Lib;

namespace Tyuiu.RazumovMO.Sprint1.Task4.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            double x , y;
            Console.WriteLine("Введите х: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите у: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(ds.Calculate(x , y));
            Console.ReadKey();

        }
    }
}
