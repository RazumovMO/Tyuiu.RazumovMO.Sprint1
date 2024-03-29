using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.RazumovMO.Sprint1.Task7.V14.Lib;

namespace Tyuiu.RazumovMO.Sprint1.Task7.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            double z = ds.Calculate(x, y);
            Console.WriteLine(ds.Cut(z));
            

            Console.ReadKey();
        }        
    }
}
