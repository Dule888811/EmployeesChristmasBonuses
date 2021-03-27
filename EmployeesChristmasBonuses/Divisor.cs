using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesChristmasBonuses
{
    class Divisor
    {
        public static List<int> GetDevisiors(List<int> Divisors, int ii)
        {
            for (int x = 1; x < ii; x++)
            {
                if (ii % x == 0)
                {
                    Divisors.Add(x);
                }
                else
                {
                    continue;
                }
            }
        
           
            return Divisors;
        }
    }
}

