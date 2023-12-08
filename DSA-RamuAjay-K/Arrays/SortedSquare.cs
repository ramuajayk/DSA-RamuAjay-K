using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_RamuAjay_K.Arrays
{
    internal class SortedSquare
    {
        public int[] SortedSquaredArray(int[] input)
        {
            int[] result = new int[input.Length];
            for (int i = 0; i < input.Length; i++)            
                result[i] = input[i] * input[i];           

            Array.Sort(result);
            return result;
        }
    }
}
