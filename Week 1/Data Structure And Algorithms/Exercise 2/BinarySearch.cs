using System;

namespace SearchAlgorithms
{
    public class BinarySearch
    {
        public static Product Search(Product[] sortedProducts, int targetId)
        {
            int low = 0;
            int high = sortedProducts.Length - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (sortedProducts[mid].ProductId == targetId)
                    return sortedProducts[mid];

                if (sortedProducts[mid].ProductId < targetId)
                    low = mid + 1;
                else
                    high = mid - 1;
            }
            return null;
        }
    }
}