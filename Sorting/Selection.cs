using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginningCS.Sorting
{
    class Selection
    {
        public static void DoIt(int[] list)
        {
            for (int j = 0; j < list.Length - 1; j++)
            {
                int iMin = j;
                for (int i = j; i < list.Length; i++)
                {
                    if (list[i] < list[iMin])
                    {
                        iMin = i;
                    }
                }
                if (iMin != j)
                {
                    SortUtils.Swap(list, iMin, j);
                }
            }
        }
    }
}
