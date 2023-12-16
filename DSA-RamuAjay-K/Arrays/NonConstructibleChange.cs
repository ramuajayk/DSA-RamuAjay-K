using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_RamuAjay_K.Arrays
{
    internal class NonConstructibleChange
    {
        public int ChangeCantCreate(int[] input)
        {
            int changeCantCreate = 0;
            Array.Sort(input);
            foreach (var coin in input) 
            {
                if (changeCantCreate + 1 < coin)
                    return changeCantCreate + 1;

                changeCantCreate += coin;
            }
            return changeCantCreate + 1;
            
             
        }
    }
}
