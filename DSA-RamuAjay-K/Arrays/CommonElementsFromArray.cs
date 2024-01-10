namespace DSA_RamuAjay_K.Arrays
{
    internal class CommonElementsFromArray
    {
        public List<int> FindCommonElements(int[] a , int[] b)
        {
            ISet<int> first = new HashSet<int>(a);
            List<int> result = new List<int>();
            foreach (int i in b)
            {
                if(!first.Add(i))
                    result.Add(i);
            }

            return result;
        }

    }
}
