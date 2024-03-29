using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.RazumovMO.Sprint1.Task5.V6.Lib
{
    public class DataService : ISprint1Task5V6
    {
        
        
        public int Calculate(int k)
        {
            int n = 0;
            
            int Week(int b)
            {
                for (int i = b; i <= 365; i += 7)
                {
                    if (i == k)
                    {
                        n = b;                     
                    }
                    else
                        continue;
                }
                return n;
            }

            for (int d = 1; d <= 7; d += 1)
            {
                if (Week(d) == 0)
                    continue;

                else if (Week(d) == d)
                    return n;
            }

            return n;
            
        }

    }
}
