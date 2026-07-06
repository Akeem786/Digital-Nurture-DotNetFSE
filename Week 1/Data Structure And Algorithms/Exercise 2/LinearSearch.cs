using System;

namespace SearchAlgorithms
{
    public class LinearSearch
    {
        public static Product Search(Product[] products, int targetId)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].ProductId == targetId)
                    return products[i];
            }
            return null;
        }
    }
}