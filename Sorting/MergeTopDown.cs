using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginningCS.Sorting
{
    class MergeTopDown : MergeSort
    {
        public static void DoIt(int[] list)
        {
            int[] sorted = new int[list.Length];
            CopyArray(list, 0, list.Length, sorted);
            Split(list, 0, list.Length, sorted);
        }

        private static void Split(int[] original, int iBegin, int iEnd, int[] sorted){
            if (iEnd - iBegin < 2)
            {
                return;
            }
            
            int iMiddle = (iEnd + iBegin) / 2;
            
            Split(original, iBegin, iMiddle, sorted);
            Split(original, iMiddle, iEnd, sorted);
            Merge(original, iBegin, iMiddle, iEnd, sorted);
            CopyArray(sorted, iBegin, iEnd, original);
        }

        private static void CopyArray(int[] from, int iBegin, int iEnd, int[] to)
        {
            for (int k = iBegin; k < iEnd; k++)
            {
                to[k] = from[k];
            }
        }
    }
}
