using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_RamuAjay_K.Arrays
{
    internal class ValidateSubSequence
    {
        public static bool ValidateSubSequentce(int[] mainArray, int[] subArray)
        {
            if (subArray.Length > mainArray.Length) return false;

            int runningIteration = 0;
            int matchCount = 0;
            while (runningIteration < mainArray.Length && matchCount < subArray.Length)
            {
                if (subArray[matchCount] == mainArray[runningIteration])
                {
                    matchCount++;
                }

                runningIteration++;
            }

            return matchCount == subArray.Length;

        }
    }
}
