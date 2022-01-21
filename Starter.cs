using System;

namespace Module2HW1
{
    public class Starter
    {
        static Starter()
        {
            Logg = Logger.Instance;
        }

        public static Logger Logg { get; set; }

        public static void Run()
        {
            for (int i = 0; i < 100; i++)
            {
                var random = new Random();
                int value = random.Next(1, 4);

                Result result = GetResult(value);

                if (!result.Status)
                {
                    Logg.Logs.Append($"{DateTime.Now}: Error: Action failed by a reason: {result.ErrorMessage}\n");
                }
            }

            Logg.WriteLogs();
            Logg.Tofile();
        }

        private static Result GetResult(int value)
        {
            var result = new Result();

            switch (value)
            {
                case 1:
                    result = Actions.CallError();
                    break;
                case 2:
                    result = Actions.CallWarning();
                    break;
                case 3:
                    result = Actions.CallInfo();
                    break;
            }

            return result;
        }
    }
}
