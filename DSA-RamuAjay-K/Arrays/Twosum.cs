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
            return new int[0];
        }

        public int[] TwoNumberSumWithSlidingWindow(int[] input, int target)
        {

            //1,34,5
            Array.Sort(input);///1,5,34
            int left =0;
            int right =input.Length - 1;    
            while (left < right)
            {
                if (input[left] + input[right] == target)
                    return new int[] { input[left], input[right] };
                else if (input[left] + input[right] > target) {
                    right--;

                }
                else if (input[left] + input[right] < target) {
                    left++;
                }

            }
            return new int[0];
        }


    }
}
