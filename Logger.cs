using System;
using System.IO;
using System.Text;

namespace Module2HW1
{
    public class Logger
    {
        private static readonly Logger _instance;
        private StringBuilder _logs;

        static Logger()
        {
            _instance = new Logger();
        }

        private Logger()
        {
            _logs = new StringBuilder();
        }

        public StringBuilder Logs => _logs;

        public static Logger Instance => _instance;

        public void WriteLogs()
        {
            Console.WriteLine(Logs.ToString());
        }

        public void Tofile()
        {
            File.WriteAllText("log.txt", Logs.ToString());
        }
    }
}