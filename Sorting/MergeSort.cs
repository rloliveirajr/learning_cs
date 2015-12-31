using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginningCS.Sorting
{
    class MergeSort
    {
        protected static void Merge(int[] original, int iLeft, int iRight, int iEnd, int[] sorted)
        {
            int i = iLeft;
            int j = iRight;
            for (int k = iLeft; k < iEnd; k++)
            {
                if (i < iRight && (j >= iEnd || original[i] <= original[j]))
                {
                    sorted[k] = original[i];
                    i++;
                }
                else
                {
                    sorted[k] = original[j];
                    j++;
                }

            }
        } 
    }
}
