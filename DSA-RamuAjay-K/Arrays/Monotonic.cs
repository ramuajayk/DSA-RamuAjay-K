namespace DSA_RamuAjay_K.Arrays
{
    internal class Monotonic
    {
        public bool MonotonicArray()
        {
            int[] array = new int[] { -1, -5, -10, -1100, -1101, -900, -1102, -9001 };
            if (array.Length < 3)
                return true;

            int left = 0;
            int j = 1;
            bool isAsc = false;
            if (array[left] < array[j])
                isAsc = true;
            left++;
            j++;
            while (j < array.Length)
            {
                if (array[left] > array[j] && isAsc)
                    return false;
                left++;
                j++;

            }
            return true;
        }
    }
}
