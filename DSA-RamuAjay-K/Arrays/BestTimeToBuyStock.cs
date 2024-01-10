namespace DSA_RamuAjay_K.Arrays
{
    internal class BestTimeToBuyStock
    {
        public int BestTime()
        {

            int[] array = { 7, 1, 5, 3, 6, 4 };
            int left = 0;
            int right = 1;
            int MaxProfit = 0;
            int pivot = 0;
            while (right < array.Length)
            {
                pivot = Math.Min(array[left], array[right]);//pivot = 1;;;

                MaxProfit = Math.Max(MaxProfit, array[right] - pivot);
                left++;
                right++;

            }


            return MaxProfit;

        }
    }
}
