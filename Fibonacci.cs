using System;

namespace BeginningCS
{
    public static class Fibonacci
    {
        public static long Recursive(long n)
        {
            if(n < 2)
            {
                return n;
            }
            
            return Recursive(n - 1) + Recursive(n - 2);
        }

        public static long RecursiveTernary(long n)
        {
            return n < 2 ? n : RecursiveTernary(n - 1) + RecursiveTernary(n - 2);
        }

        public static long TailRecursive(long n)
        {
            return TailRecursive(n, 0, 1);
        }

        private static long TailRecursive(long n, long a, long b)
        {
            if(n < 1)
            {
                return a;
            }

            return TailRecursive(n - 1, a + b, a);
        }

        public static long BinetsFormula(long n)
        {
            double fi = (1 + Math.Sqrt(5)) / 2;

            return (long) ((Math.Pow(fi, n) - Math.Pow(1 - fi, n)) / Math.Sqrt(5));
        }

        public static long Iterative(long n)
        {
            long i = 0;
            long j = 1;
            long k, t;

            for(k = 1; k < n; k++)
            {
                t = i + j;
                i = j;
                j = t;
            }

            return j;
        }

        public static long ExponetiationBySquaring(long n)
        {
            long i = n - 1;
            long a = 1;
            long b = 0;
            long c = 0;
            long d = 1;
            long t;

            if (n <= 0) 
                return 0;

            while(i > 0)
            {
                if (i % 2 == 1)
                {
                    t = d * (b + a) + c * b;
                    a = d * b + c * a;
                    b = t;
                }
                t = d * (2 * c + d);
                c = c * c + d * d;
                d = t;
                i = i / 2;
            }

            return a + b;
        }
    }
}
