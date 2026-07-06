using System;

namespace FinancialForecasting
{
    public class ForecastTest
    {
        public static void Main(string[] args)
        {
            double principal = 10000;   // starting investment
            double growthRate = 0.08;   // 8% annual growth
            int years = 10;

            double futureValue = Forecaster.CalculateFutureValue(principal, growthRate, years);

            Console.WriteLine($"Starting amount: {principal}");
            Console.WriteLine($"Annual growth rate: {growthRate * 100}%");
            Console.WriteLine($"Years: {years}");
            Console.WriteLine($"Projected future value: {futureValue:F2}");

            // Show growth year by year
            Console.WriteLine("\nYear-by-year projection:");
            for (int y = 0; y <= years; y++)
            {
                double value = Forecaster.CalculateFutureValue(principal, growthRate, y);
                Console.WriteLine($"Year {y}: {value:F2}");
            }
        }
    }
}