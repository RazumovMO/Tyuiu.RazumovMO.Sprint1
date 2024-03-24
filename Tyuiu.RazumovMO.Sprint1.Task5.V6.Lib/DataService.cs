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

            for (int i = 1; i <= 365; i += 7)
            {
                if (i == k)
                {
                    n = 1;
                    return n;
                }

                else
                    continue;
            }

            for (int i = 2; i <= 365; i += 7)
            {
                if (i == k)
                {
                    n = 2;
                    return n;
                }

                else
                    continue;
            }

            for (int i = 3; i <= 365; i += 7)
            {
                if (i == k)
                {
                    n = 3;
                    return n;
                }

                else
                    continue;
            }

            for (int i = 4; i <= 365; i += 7)
            {
                if (i == k)
                {
                    n = 4;
                    return n;
                }

                else
                    continue;
            }

            for (int i = 5; i <= 365; i += 7)
            {
                if (i == k)
                {
                    n = 5;
                    return n;
                }

                else
                    continue;
            }

            for (int i = 6; i <= 365; i += 7)
            {
                if (i == k)
                {
                    n = 6;
                    return n;
                }

                else
                    continue;
            }

            for (int i = 7; i <= 365; i += 7)
            {
                if (i == k)
                {
                    n = 7;
                    return n;
                }

                else
                    continue;
            }

            return n;
            


        }
    }
}
