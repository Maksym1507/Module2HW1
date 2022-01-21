using System;

namespace Module2HW1
{
    public class Actions
    {
        private static Logger _logger;

        static Actions()
        {
            _logger = Logger.Instance;
        }

        public static Logger Logger => _logger;

        public static Result CallError()
        {
            return new Result { ErrorMessage = "I broke a logic", Status = false };
        }

        public static Result CallInfo()
        {
            Logger.Logs.Append($"{DateTime.Now}: Info: Start method: {nameof(CallInfo)}\n");
            return new Result() { Status = true };
        }

        public static Result CallWarning()
        {
            Logger.Logs.Append($"{DateTime.Now}: Warning: Skipped logic in method: {nameof(CallWarning)}\n");
            return new Result() { Status = true };
        }
    }
}
