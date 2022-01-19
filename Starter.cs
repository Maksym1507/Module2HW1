using System;
using System.IO;

namespace Module2HW1
{
    public static class Starter
    {
        public static Logger Logg { get; set; }

        public static void Run()
        {
            Logg = Logger.Instance;

            for (int i = 0; i < 100; i++)
            {
                var random = new Random();
                int value = random.Next(1, 4);

                Result result = GetResult(value);

                if (result.Status == false)
                {
                    Logg.Logs.Append($"{DateTime.Now}: Error: Action failed by a reason: {result.ErrorMessage}\n");
                }

                Result GetResult(int value)
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

            Logg.GetLoggers();
            File.WriteAllText("log.txt", Logg.Logs.ToString());
        }
    }
}
