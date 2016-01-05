using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeginningCS.Sorting;

namespace BeginningCS.Sorting
{
    class SortMethods
    {
        public static void Run()
        {
            int[] a = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0, -1, -2, -4, -3, -5, -6, -7, -8, -9 };
            Bubble.DoIt(a);
            Console.WriteLine(string.Join(",", a));
        }
    }
}
