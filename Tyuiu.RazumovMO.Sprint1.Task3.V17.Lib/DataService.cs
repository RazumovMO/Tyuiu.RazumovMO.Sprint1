using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.RazumovMO.Sprint1.Task3.V17.Lib
{
    public class DataService : ISprint1Task3V17
    {
        public bool ZeroCheck(double number)
        {
            double numm = Math.Truncate(number);
            double num = ((number-numm) * 1000);
            
            double num1 , num2 , num3;

            num1 = Math.Truncate(num / 100);
            num2 = Math.Truncate((num - num1*100) / 10);
            num3 = Math.Truncate((num - num1 * 100 - num2 * 10));

            if (num1 == 0)
                return true;

            if (num2 == 0) 
                return true;

            if (num3 == 0)
                return true;

            else
                return false;


        }
    }
}
