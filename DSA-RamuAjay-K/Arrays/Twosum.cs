using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_RamuAjay_K.Arrays
{
    internal class Twosum
    {
       
        public int[] TwoNumberSumWithLookUp(int[] input, int target) 
        {

            HashSet<int> storeIteration = new HashSet<int>();
            foreach (int i in input)
            {
                int sum = target - i;
                if (storeIteration.Contains(sum))
                {
                   return new int[2]{sum, i};
                }
                else
                {
                    storeIteration.Add(i);  
                }
            }
            return new int[2] { 0, 0 };
        }

        public int[] TwoNumberSumWithSlidingWindow(int[] input, int target)
        {
            Array.Sort(input);
            
        }


    }
}
