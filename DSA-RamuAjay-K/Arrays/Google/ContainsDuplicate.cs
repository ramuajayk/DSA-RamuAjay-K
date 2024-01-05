using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_RamuAjay_K.Arrays.Google
{
    internal class ContainsDuplicate
    {

        public bool ContainsDuplicateValues(int[] array)
        {

            HashSet<int> result = new HashSet<int>();
            foreach (int item in array)
            {
                if(!result.Add(item))
                    return true;
               
            }
            return false;
        }
    }
}
