namespace DSA_RamuAjay_K.Arrays
{
    internal class IndexCrest
    {

        public int IndexPosGreaterthanNeighbours(int[] array)
        {
            //{1,9,12,4,6 }
            int left = 0;
            int pivot = 1;
            int right = pivot + 1;
            while (right < array.Length)
            {
                if (array[right] < array[pivot] && array[left] < array[pivot])
                    return pivot;
                left++;
                pivot++;
                right++;
            }


            return -1;
        }
    }
}
