using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginningCS.Sorting
{
    class QuickSort
    {
        public static void DoIt(int[] list)
        {
            Partition(list, 0, list.Length-1);
        }

        private static void Partition(int[] list, int lo, int hi)
        {
            if (lo < hi)
            {
                int p = Sort(list, lo, hi);
                Partition(list, lo, p - 1);
                Partition(list, p + 1, hi);
            }
        }

        private static int Sort(int[] list, int lo, int hi)
        {
            int pivot = list[hi];
            int i = lo;
            for (int j = lo; j < hi; j++)
            {
                if (list[j] <= pivot)
                {
                    SortUtils.Swap(list, i, j);
                    i++;
                }
            }
            SortUtils.Swap(list, i, hi);
            return i;
        }
    }
}
