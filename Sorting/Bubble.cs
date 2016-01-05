using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginningCS.Sorting
{
    class Bubble
    {
        public static void DoIt(int[] list)
        {
            for (int i = 1; i < list.Length; i++)
            {
                for (int j = 0; j < list.Length; j++)
                {
                    if (list[i] < list[j])
                    {
                        SortUtils.Swap(list, i, j);
                    }
                }
            }
        }
    }
}
