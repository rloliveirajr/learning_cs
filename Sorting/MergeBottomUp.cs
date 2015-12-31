using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginningCS.Sorting
{
    class MergeBottomUp : MergeSort
    {
        public static void DoIt(int[] list)
        {
            int[] sorted = new int[list.Length];
            CopyArray(list, sorted);
            Split(list, sorted);
        }

        private static void Split(int[] original, int[] sorted)
        {
            int n = original.Length;
            for (int width = 1; width < n; width *= 2)
            {
                for (int i = 0; i < n; i += 2 * width)
                {
                    Merge(original, i, Math.Min(i + width, n), Math.Min(i + 2 * width, n), sorted);
                }
                CopyArray(sorted, original);
            }
        }
  

        public static void CopyArray(int[] from, int[] to)
        {
            for (int k = 0; k < from.Length; k++)
            {
                to[k] = from[k];
            }
        }
    }
}
