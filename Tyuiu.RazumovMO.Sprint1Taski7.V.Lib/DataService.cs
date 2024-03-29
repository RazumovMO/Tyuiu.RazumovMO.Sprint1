using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.RazumovMO.Sprint1.Task7.V14.Lib
{
    public class DataService : ISprint1Task7V14
    {
        public double Calculate(double x, double y)
        {
            
            return ((Math.Pow(((x + 1) / (x - 1)) , x)) + (18 * x * (Math.Pow(y, 2))));
            
            
        }

        public double Cut(double z)
        {
            z *= 1000;
            z = Math.Truncate(z);
            z /= 1000;
            return z;

        }
    }
}

