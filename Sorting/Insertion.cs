using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginningCS.Sorting
{
    class Insertion
    {
        public static void DoIt(int[] list){

            int j;
            for (int i = 1; i < list.Length; i++)
            {
                j = i;
                while (j > 0 && list[j - 1] > list[j])
                {
                    SortUtils.Swap(list, j, j - 1);
                    j--;
                }
            }
        }
    }
}
