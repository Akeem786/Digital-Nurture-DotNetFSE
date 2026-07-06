using System;
using System.Linq;

namespace SearchAlgorithms
{
    public class SearchTest
    {
        public static void Main(string[] args)
        {
            Product[] products = new Product[]
            {
                new Product(105, "Wireless Mouse", "Electronics"),
                new Product(102, "Yoga Mat", "Fitness"),
                new Product(110, "Bluetooth Speaker", "Electronics"),
                new Product(101, "Running Shoes", "Footwear"),
                new Product(108, "Office Chair", "Furniture")
            };

            Console.WriteLine("--- Linear Search (unsorted array) ---");
            Product foundLinear = LinearSearch.Search(products, 110);
            Console.WriteLine(foundLinear != null ? foundLinear.ToString() : "Not found");

            Product[] sortedProducts = products.OrderBy(p => p.ProductId).ToArray();

            Console.WriteLine("\n--- Binary Search (sorted array) ---");
            Product foundBinary = BinarySearch.Search(sortedProducts, 110);
            Console.WriteLine(foundBinary != null ? foundBinary.ToString() : "Not found");

            Console.WriteLine("\n--- Searching for a non-existent ID ---");
            Console.WriteLine(LinearSearch.Search(products, 999) == null ? "Not found (linear)" : "Found");
            Console.WriteLine(BinarySearch.Search(sortedProducts, 999) == null ? "Not found (binary)" : "Found");
        }
    }
}