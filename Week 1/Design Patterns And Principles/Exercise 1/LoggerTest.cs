using System;

namespace SingletonPatternExample
{
    public class LoggerTest
    {
        public static void Main(string[] args)
        {
            Logger logger1 = Logger.Instance;
            logger1.Log("Application started.");

            Logger logger2 = Logger.Instance;
            logger2.Log("Fetching user data.");

            Logger logger3 = Logger.Instance;
            logger3.Log("User data fetched successfully.");

            Console.WriteLine(ReferenceEquals(logger1, logger2));
            Console.WriteLine(ReferenceEquals(logger2, logger3));
            Console.WriteLine(logger1.GetLogCount());
        }
    }
}