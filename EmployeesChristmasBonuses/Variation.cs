using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesChristmasBonuses
{
    class Variation
    {
        public static void Variations(int[] Array1, int[] Array2, bool[] printing, int ii, int n, int k, int j, int[] Dev)
        {

            if (printing[1] == true)

            {

                for (int i = 1; i <= n; i++)
                    if (Array1[i] == 0)
                    {
                        Array1[i] = 1;
                        Array2[j] = i;
                        if (j < k)
                        {
                            if (printing[1] == true)
                            { Variations(Array1, Array2, printing, ii, n, k, j + 1, Dev); }

                        }

                        else
                        {
                            int summ = 0;
                            for (int r = 1; r <= k; r++)
                            {
                                summ = summ + Dev[Array2[r]];


                            }


                            if (summ == ii)
                            {
                                printing[1] = false;

                            }




                        }

                        Array1[i] = 0;
                    }
            }
        }
    }
}
