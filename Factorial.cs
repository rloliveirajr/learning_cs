using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginningCS
{
    public static class Factorial
    {
        public static long Iterative(long n)
        {
            if (n < 2)
            {
                return 1;
            }

            long t = 1;
            for (int i = 1; i <= n; i++)
            {
                t = i * t;
            }

            return t;
        }

        public static long Recursive(long n)
        {
            if (n < 2)
            {
                return 1;
            }

            return Recursive(n - 1) * n;
        }
    }
}
