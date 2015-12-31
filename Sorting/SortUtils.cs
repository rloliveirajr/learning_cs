using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginningCS.Sorting
{
    class SortUtils
    {
        public static void Swap(int[] list, int pos1, int pos2)
        {
            int t = list[pos1];
            list[pos1] = list[pos2];
            list[pos2] = t;
        }
    }
}
