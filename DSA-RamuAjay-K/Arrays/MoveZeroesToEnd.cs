using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_RamuAjay_K.Arrays
{
    internal class MoveZeroesToEnd
    {
        public int[] MoveZeros(int[] array)
        {
            ///9,8,7,0,3,4,5,9
            ///8,98,0,78,9,123,0
            ///
            int left = 0;
            int right = array.Length - 1;

            while (left < right)
            {
                while (left < right && array[right] == 0)
                    right--;
                if (array[left] == 0)
                {
                    Swap(array, left, right);
                }
                left++;

                return array;
            }
          
        }
        public void Swap(int[] array,int left, int right)
        {
            int temp = array[left];
            array[left] = array[right];
            array[right] = temp;
        }

    }
}


