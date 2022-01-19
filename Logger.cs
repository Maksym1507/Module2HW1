using System;
using System.Text;

namespace Module2HW1
{
    public class Logger
    {
        private static readonly Logger _instance = new Logger();
        private StringBuilder _logs;

        static Logger()
        {
            _instance._logs = new StringBuilder();
        }

        private Logger()
        {
        }

        public StringBuilder Logs => _logs;

        public static Logger Instance
        {
            get
            {
                return _instance;
            }
        }

        public void GetLogs()
        {
            Console.WriteLine(Logs);
        }
    }
}