using System;

namespace FinancialForecasting
{
    public class Forecaster
    {
        // Recursive future value calculation
        public static double CalculateFutureValue(double principal, double growthRate, int years)
        {
            if (years == 0)
                return principal;

            return CalculateFutureValue(principal, growthRate, years - 1) * (1 + growthRate);
        }
    }
}