namespace DSA_RamuAjay_K.Arrays
{
    internal class Kadane
    {

        public int MaxSubArray(int[] array)
        {
            int maxEndingHere = array[0];
            int maxSoFar = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                int currentNum = array[i];
                maxEndingHere = Math.Max(maxEndingHere + currentNum, currentNum);
                maxSoFar = Math.Max(maxSoFar, maxEndingHere);
            }
            return maxSoFar;


        }


        public int MaxSubArrayIfElse(int[] array)
        {
            int maxEndingHere = array[0];
            int maxSoFar = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                int currentNum = array[i];
                if (maxEndingHere + currentNum > currentNum)
                    maxEndingHere += currentNum;
                else
                    maxEndingHere = currentNum;

                if (maxEndingHere > maxSoFar)
                    maxSoFar = maxEndingHere;

            }



            return maxSoFar;


        }
    }
}
