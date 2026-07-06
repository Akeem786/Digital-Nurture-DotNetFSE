using System;

namespace SingletonPatternExample
{
    public class Logger
    {
        private static Logger _instance;
        private static readonly object _lock = new object();
        private int _logCount = 0;

        private Logger() { }

        public static Logger Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                        _instance = new Logger();
                    return _instance;
                }
            }
        }

        public void Log(string message)
        {
            _logCount++;
            Console.WriteLine($"[LOG #{_logCount}] {message}");
        }

        public int GetLogCount()
        {
            return _logCount;
        }
    }
}