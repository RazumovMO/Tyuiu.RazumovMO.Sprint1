using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.RazumovMO.Sprint1.Task5.V6.Lib;

namespace Tyuiu.RazumovMO.Sprint1.Task5.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = Convert.ToInt32(Console.ReadLine());

            DataService ds = new DataService();
            Console.WriteLine(ds.Calculate(k));
            Console.ReadKey();
        }
    }
}
